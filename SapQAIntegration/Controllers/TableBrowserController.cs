using Microsoft.AspNetCore.Mvc;
using Sap.Data.Hana;
using System.Data;

namespace SapQAIntegration.Controllers;

[ApiController]
[Route("api/admin")]
public class TableBrowserController : ControllerBase
{
    private readonly string _connectionString;
    private const string Schema = "SAPHANADB";

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
        if (page < 1) page = 1;
        if (pageSize is < 1 or > 200) pageSize = 50;

        // Tablo adı sadece harf, rakam ve alt çizgi içerebilir
        if (!System.Text.RegularExpressions.Regex.IsMatch(tableName, @"^[A-Za-z0-9_]+$"))
            return BadRequest(new { error = "Geçersiz tablo adı." });

        int offset = (page - 1) * pageSize;
        var fqTable = $"\"{Schema}\".\"{tableName}\"";

        try
        {
            await using var conn = new HanaConnection(_connectionString);
            await conn.OpenAsync();

            // Sütun listesini çek
            var colSql = $"SELECT COLUMN_NAME, DATA_TYPE_NAME FROM SYS.TABLE_COLUMNS WHERE SCHEMA_NAME = '{Schema}' AND TABLE_NAME = '{tableName.Replace("'", "''")}' ORDER BY POSITION";
            var colMappings = new List<(string name, string type, bool isString)>();
            await using (var colCmd = new HanaCommand(colSql, conn))
            await using (var colReader = await colCmd.ExecuteReaderAsync())
            {
                while (await colReader.ReadAsync())
                {
                    var col = colReader.GetString(0);
                    var dbType = colReader.GetString(1);
                    var isStr = dbType.Contains("CHAR") || dbType.Contains("CLOB") || dbType.Contains("TEXT");
                    colMappings.Add((col, dbType, isStr));
                }
            }

            if (colMappings.Count == 0)
                return NotFound(new { error = $"Tablo '{tableName}' bulunamadı." });

            var whereClause = "";
            if (!string.IsNullOrWhiteSpace(filter))
            {
                var safe = filter.Replace("'", "''");
                var conditions = colMappings.Select(c =>
                    c.isString
                        ? $"\"{c.name}\" LIKE '%{safe}%'"
                        : $"TO_VARCHAR(\"{c.name}\") LIKE '%{safe}%'"
                ).ToList();
                whereClause = $"WHERE ({string.Join(" OR ", conditions)})";
            }

            var orderCol = colMappings[0].name;
            var dataSql = $"SELECT * FROM {fqTable} {whereClause} ORDER BY \"{orderCol}\" LIMIT {pageSize} OFFSET {offset}";

            var columns = colMappings.Select(c => new { name = c.name, type = c.type }).ToList();
            var rows = new List<Dictionary<string, object?>>();

            await using var dataCmd = new HanaCommand(dataSql, conn);
            await using var dataReader = await dataCmd.ExecuteReaderAsync();
            while (await dataReader.ReadAsync())
            {
                var row = new Dictionary<string, object?>();
                for (int i = 0; i < dataReader.FieldCount; i++)
                    row[colMappings[i].name] = dataReader.IsDBNull(i) ? null : dataReader.GetValue(i);
                rows.Add(row);
            }

            return Ok(new { columns, rows });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.InnerException?.Message ?? ex.Message });
        }
    }
}
