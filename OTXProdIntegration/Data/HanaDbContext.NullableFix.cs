using Microsoft.EntityFrameworkCore;

namespace OTXProdIntegration.Data;

public partial class HanaDbContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            var keyProps = entity.FindPrimaryKey()?.Properties
                .Select(p => p.Name).ToHashSet()
                ?? [];

            foreach (var prop in entity.GetProperties())
            {
                if (!keyProps.Contains(prop.Name))
                    prop.IsNullable = true;
            }
        }
    }
}
