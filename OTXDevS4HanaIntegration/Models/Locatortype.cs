using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Locatortype
{
    public string Locatortype1 { get; set; } = null!;

    public string? DescE { get; set; }

    public decimal? Locatortypedepth { get; set; }

    public decimal? Locatortypeheight { get; set; }

    public decimal? Locatortypelength { get; set; }

    public decimal? Locatortypetotal { get; set; }

    public byte? Disabledflag { get; set; }
}
