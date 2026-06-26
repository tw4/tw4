using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llprospector
{
    public long? Resultid { get; set; }

    public string? Filedate { get; set; }

    public string? Filename { get; set; }

    public string? Filesize { get; set; }

    public string? Filetime { get; set; }

    public long? InfoSource { get; set; }

    public DateTime? MatchTime { get; set; }

    public long? Otdataid { get; set; }

    public string? Otfiltermimetype { get; set; }

    public string Otobject { get; set; } = null!;

    public long? Otscore { get; set; }

    public string? Otsummary { get; set; }

    public long? Prospectorid { get; set; }

    public string Status { get; set; } = null!;

    public string? Otlocationlink { get; set; }

    public string? Otlocationtitle { get; set; }
}
