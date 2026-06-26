using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Storagelocator
{
    public string Facility { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Boxlocator { get; set; } = null!;

    public string? Locatortype { get; set; }

    public string? Refrate { get; set; }

    public decimal? Totalspace { get; set; }

    public decimal? Freespace { get; set; }

    public decimal? Storlocdepth { get; set; }

    public decimal? Storlocheight { get; set; }

    public decimal? Storloclength { get; set; }

    public string? Locatorsortkey { get; set; }
}
