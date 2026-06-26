using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ksystemhealthresult
{
    public long? Rowidnum { get; set; }

    public string? Testkey { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? Profilekey { get; set; }

    public string? Subsystemkey { get; set; }

    public string? Instance { get; set; }

    public string? Operator { get; set; }

    public int? State { get; set; }

    public long? Duration { get; set; }

    public string? Message { get; set; }
}
