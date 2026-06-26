using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OTXProdIntegration.Data;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;

namespace OTXProdIntegration.Controllers;

[ApiController]
[Route("api/admin")]
public class TableBrowserController : ControllerBase
{
    private readonly HanaDbContext _context;

    private static readonly Dictionary<string, Type> _entityTypes =
        typeof(HanaDbContext)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
            .ToDictionary(
                p => p.Name,
                p => p.PropertyType.GetGenericArguments()[0],
                StringComparer.OrdinalIgnoreCase
            );

    public TableBrowserController(HanaDbContext context) => _context = context;

    [HttpGet("tables")]
    public IActionResult GetTables()
    {
        var tables = _entityTypes.Keys.OrderBy(k => k)
            .Select(k => new { name = k })
            .ToList();
        return Ok(tables);
    }

    [HttpGet("tables/{tableName}")]
    public async Task<IActionResult> GetTableData(
        string tableName,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50,
        [FromQuery] string? filter = null)
    {
        if (!_entityTypes.TryGetValue(tableName, out var entityType))
            return NotFound($"Table '{tableName}' not found.");

        if (page < 1) page = 1;
        if (pageSize is < 1 or > 200) pageSize = 50;

        // Filter varsa raw SQL kullan — EF Core dinamik WHERE yapamaz
        if (!string.IsNullOrWhiteSpace(filter))
        {
            try
            {
                var result = await QueryRaw(entityType, (page - 1) * pageSize, pageSize, filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.InnerException?.Message ?? ex.Message });
            }
        }

        try
        {
            var method = GetType()
                .GetMethod(nameof(FetchEF), BindingFlags.NonPublic | BindingFlags.Instance)!
                .MakeGenericMethod(entityType);

            var result = await (Task<object>)method.Invoke(this, [(page - 1) * pageSize, pageSize])!;
            return Ok(result);
        }
        catch (Exception ex) when (IsNullDataException(ex))
        {
            // SAP HANA provider NULL bug — tabloda NOT NULL tanımlı ama gerçekte NULL var
            // EF Core materialization bunu okuyamıyor, raw SQL ile okuyoruz
            try
            {
                var result = await QueryRaw(entityType, (page - 1) * pageSize, pageSize);
                return Ok(result);
            }
            catch (Exception rawEx)
            {
                return StatusCode(500, new { error = rawEx.InnerException?.Message ?? rawEx.Message });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.InnerException?.Message ?? ex.Message });
        }
    }

    // EF Core ile okuma — çoğu tablo bu yoldan çalışır
    private async Task<object> FetchEF<T>(int skip, int take) where T : class
    {
        var query = ApplyOrder(_context.Set<T>());
        var rows = await query.Skip(skip).Take(take).ToListAsync();
        var columns = typeof(T).GetProperties().Select(p => new
        {
            name = char.ToLowerInvariant(p.Name[0]) + p.Name[1..],
            type = FriendlyTypeName(p.PropertyType)
        }).ToList();
        return new { columns, rows };
    }

    // Raw SQL fallback — NULL veri kalite sorunu olan tablolar için + filter desteği
    private async Task<object> QueryRaw(Type entityType, int skip, int take, string? filter = null)
    {
        var entityMeta = _context.Model.FindEntityType(entityType)!;
        var tableName = entityMeta.GetTableName()!;
        var schema = entityMeta.GetSchema();

        var colMappings = entityMeta.GetProperties()
            .Select(p => new
            {
                name = char.ToLowerInvariant(p.Name[0]) + p.Name[1..],
                column = p.GetColumnName(),
                type = FriendlyTypeName(p.ClrType),
                isString = p.ClrType == typeof(string)
            })
            .ToList();

        var orderProp = entityMeta.FindPrimaryKey()?.Properties.FirstOrDefault()
                     ?? entityMeta.GetProperties().FirstOrDefault();
        var orderColumn = orderProp?.GetColumnName() ?? colMappings[0].column;

        var fqTable = schema != null ? $"\"{schema}\".\"{tableName}\"" : $"\"{tableName}\"";

        var whereClause = "";
        if (!string.IsNullOrWhiteSpace(filter))
        {
            var safeTerm = filter.Replace("'", "''");
            var conditions = colMappings.Select(c =>
                c.isString
                    ? $"\"{c.column}\" LIKE '%{safeTerm}%'"
                    : $"TO_VARCHAR(\"{c.column}\") LIKE '%{safeTerm}%'"
            ).ToList();
            whereClause = $"WHERE ({string.Join(" OR ", conditions)})";
        }

        var sql = $"SELECT * FROM {fqTable} {whereClause} ORDER BY \"{orderColumn}\" LIMIT {take} OFFSET {skip}";

        var conn = _context.Database.GetDbConnection();
        var opened = conn.State != ConnectionState.Open;
        if (opened) await conn.OpenAsync();

        try
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            using var reader = await cmd.ExecuteReaderAsync();

            var columns = Enumerable.Range(0, reader.FieldCount)
                .Select(i =>
                {
                    var dbCol = reader.GetName(i);
                    var map = colMappings.FirstOrDefault(m =>
                        string.Equals(m.column, dbCol, StringComparison.OrdinalIgnoreCase));
                    return new
                    {
                        name = map?.name ?? (char.ToLowerInvariant(dbCol[0]) + dbCol[1..]),
                        type = map?.type ?? "String"
                    };
                })
                .ToList();

            var rows = new List<Dictionary<string, object?>>();
            while (await reader.ReadAsync())
            {
                var row = new Dictionary<string, object?>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row[columns[i].name] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                rows.Add(row);
            }

            return new { columns, rows };
        }
        finally
        {
            if (opened) await conn.CloseAsync();
        }
    }

    private IQueryable<T> ApplyOrder<T>(IQueryable<T> query) where T : class
    {
        var entityMeta = _context.Model.FindEntityType(typeof(T));
        var prop = entityMeta?.FindPrimaryKey()?.Properties.FirstOrDefault()
                ?? entityMeta?.GetProperties().FirstOrDefault();

        if (prop == null) return query;

        var clrType = prop.ClrType;
        var param = Expression.Parameter(typeof(T), "e");
        var propExpr = Expression.Property(param, prop.Name);
        var lambdaType = typeof(Func<,>).MakeGenericType(typeof(T), clrType);
        var lambda = Expression.Lambda(lambdaType, propExpr, param);

        var orderByMethod = typeof(Queryable)
            .GetMethods()
            .First(m => m.Name == "OrderBy" && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(T), clrType);

        return (IQueryable<T>)orderByMethod.Invoke(null, [query, lambda])!;
    }

    private static bool IsNullDataException(Exception ex)
    {
        var msg = (ex.InnerException ?? ex).Message;
        return msg.Contains("Data is Null", StringComparison.OrdinalIgnoreCase);
    }

    private static string FriendlyTypeName(Type type)
    {
        var underlying = Nullable.GetUnderlyingType(type);
        var t = underlying ?? type;
        return underlying != null ? $"{t.Name}?" : t.Name;
    }
}
