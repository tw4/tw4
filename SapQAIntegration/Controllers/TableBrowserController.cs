using Microsoft.AspNetCore.Mvc;
using Sap.Data.Hana;
using System.Text;
using System.Text.RegularExpressions;

namespace SapQAIntegration.Controllers;

[ApiController]
[Route("api/admin")]
public class TableBrowserController : ControllerBase
{
    private readonly string _connectionString;
    private const string Schema = "SAPHANADB";
    private static readonly Regex SafeName = new(@"^[A-Za-z0-9_/]+$", RegexOptions.Compiled);

    public TableBrowserController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("HanaConnection")!;
    }

    [HttpGet("tables")]
    public async Task<IActionResult> GetTables([FromQuery] string? filter = null)
    {
        var sql = string.IsNullOrWhiteSpace(filter)
            ? $"SELECT TABLE_NAME FROM SYS.TABLES WHERE SCHEMA_NAME = '{Schema}' ORDER BY TABLE_NAME"
            : $"SELECT TABLE_NAME FROM SYS.TABLES WHERE SCHEMA_NAME = '{Schema}' AND TABLE_NAME LIKE '%{filter.Replace("'", "''")}%' ORDER BY TABLE_NAME";

        try
        {
            var tables = new List<object>();
            await using var conn = new HanaConnection(_connectionString);
            await conn.OpenAsync();
            await using var cmd = new HanaCommand(sql, conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
                tables.Add(new { name = reader.GetString(0) });

            return Ok(tables);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }

    [HttpGet("tables/{tableName}")]
    public async Task<IActionResult> GetTableData(
        string tableName,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50,
        [FromQuery] string? filter = null)
    {
        if (!SafeName.IsMatch(tableName))
            return BadRequest(new { error = "Geçersiz tablo adı." });

        if (page < 1) page = 1;
        if (pageSize is < 1 or > 200) pageSize = 50;

        int offset = (page - 1) * pageSize;

        try
        {
            await using var conn = new HanaConnection(_connectionString);
            await conn.OpenAsync();

            var colMappings = await GetColumns(conn, tableName);
            if (colMappings.Count == 0)
                return NotFound(new { error = $"Tablo '{tableName}' bulunamadı." });

            var (whereClause, _) = BuildWhere(colMappings, filter);
            var fqTable = $"\"{Schema}\".\"{tableName}\"";
            var orderCol = colMappings[0].name;
            var sql = $"SELECT * FROM {fqTable} {whereClause} ORDER BY \"{orderCol}\" LIMIT {pageSize} OFFSET {offset}";

            var columns = colMappings.Select(c => new { name = c.name, type = c.type }).ToList();
            var rows = new List<Dictionary<string, object?>>();

            await using var cmd = new HanaCommand(sql, conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var row = new Dictionary<string, object?>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row[colMappings[i].name] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                rows.Add(row);
            }

            return Ok(new { columns, rows });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.InnerException?.Message ?? ex.Message });
        }
    }

    [HttpGet("tables/{tableName}/export")]
    public async Task ExportCsv(string tableName, [FromQuery] string? filter = null)
    {
        if (!SafeName.IsMatch(tableName))
        {
            Response.StatusCode = 400;
            return;
        }

        var safeFileName = tableName.Replace("/", "_");
        Response.ContentType = "text/csv; charset=utf-8";
        Response.Headers.Append("Content-Disposition", $"attachment; filename=\"{safeFileName}.csv\"");

        // BOM — Excel Türkçe karakterleri doğru okusun
        await Response.Body.WriteAsync("\xEF\xBB\xBF"u8.ToArray());

        await using var conn = new HanaConnection(_connectionString);
        await conn.OpenAsync();

        var colMappings = await GetColumns(conn, tableName);
        if (colMappings.Count == 0) { Response.StatusCode = 404; return; }

        var (whereClause, _) = BuildWhere(colMappings, filter);
        var fqTable = $"\"{Schema}\".\"{tableName}\"";
        var orderCol = colMappings[0].name;
        var sql = $"SELECT * FROM {fqTable} {whereClause} ORDER BY \"{orderCol}\"";

        await using var writer = new StreamWriter(Response.Body, leaveOpen: true);

        // Başlık satırı
        await writer.WriteLineAsync(string.Join(",", colMappings.Select(c => CsvEscape(c.name))));

        // Veri satırları — direkt stream'e yaz, belleğe almaz
        await using var cmd = new HanaCommand(sql, conn);
        cmd.CommandTimeout = 0;
        await using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            var fields = new string[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++)
                fields[i] = CsvEscape(reader.IsDBNull(i) ? "" : reader.GetValue(i)?.ToString() ?? "");
            await writer.WriteLineAsync(string.Join(",", fields));
        }

        await writer.FlushAsync();
    }

    private static string CsvEscape(string value)
    {
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
            return $"\"{value.Replace("\"", "\"\"")}\"";
        return value;
    }

    // ── Yardımcı metodlar ──────────────────────────────────────────────────

    private async Task<List<(string name, string type, bool isString)>> GetColumns(HanaConnection conn, string tableName)
    {
        var sql = $"SELECT COLUMN_NAME, DATA_TYPE_NAME FROM SYS.TABLE_COLUMNS WHERE SCHEMA_NAME = '{Schema}' AND TABLE_NAME = '{tableName.Replace("'", "''")}' ORDER BY POSITION";
        var result = new List<(string, string, bool)>();
        await using var cmd = new HanaCommand(sql, conn);
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var col = reader.GetString(0);
            var dbType = reader.GetString(1);
            var isStr = dbType.Contains("CHAR") || dbType.Contains("CLOB") || dbType.Contains("TEXT");
            result.Add((col, dbType, isStr));
        }
        return result;
    }

    private static (string whereClause, bool hasFilter) BuildWhere(
        List<(string name, string type, bool isString)> cols, string? filter)
    {
        if (string.IsNullOrWhiteSpace(filter))
            return ("", false);

        var safe = filter.Replace("'", "''");
        var conditions = cols.Select(c =>
            c.isString
                ? $"\"{c.name}\" LIKE '%{safe}%'"
                : $"TO_VARCHAR(\"{c.name}\") LIKE '%{safe}%'"
        );
        return ($"WHERE ({string.Join(" OR ", conditions)})", true);
    }
}
