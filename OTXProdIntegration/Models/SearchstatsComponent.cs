using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class SearchstatsComponent
{
    public decimal? Querynr { get; set; }

    public long? Userid { get; set; }

    public string Subquery { get; set; } = null!;

    public long? Extradatai { get; set; }

    public string? Extradatas { get; set; }

    public string? Otsql { get; set; }

    public string? Terms { get; set; }
}
