using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CpdbCountry
{
    public long? Coid { get; set; }

    public int? Deleted { get; set; }

    public string Country { get; set; } = null!;

    public string Continent { get; set; } = null!;

    public string Iso2 { get; set; } = null!;
}
