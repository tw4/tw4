using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Catregionmap
{
    public long? Catid { get; set; }

    public string? Catname { get; set; }

    public string? Setname { get; set; }

    public string? Attrname { get; set; }

    public string Regionname { get; set; } = null!;

    public int? Attrtype { get; set; }

    public int? Reportinglevel { get; set; }
}
