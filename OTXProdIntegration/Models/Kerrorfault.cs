using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kerrorfault
{
    public long? Rowidnum { get; set; }

    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public short? Severity { get; set; }

    public long? Faultid { get; set; }

    public DateTime? Datestamp { get; set; }

    public long? Threadindex { get; set; }

    public string? Instanceid { get; set; }

    public string? Data { get; set; }
}
