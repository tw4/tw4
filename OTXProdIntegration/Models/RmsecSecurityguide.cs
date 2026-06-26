using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmsecSecurityguide
{
    public long? Securityguideid { get; set; }

    public string? Inforevealing { get; set; }

    public int? Securitylevel { get; set; }

    public string? Reasonsfor { get; set; }

    public byte? Declassifytype { get; set; }

    public DateTime? Declassifydate { get; set; }

    public string? Declassifyevent { get; set; }

    public string? Exemptioncats { get; set; }

    public string? Guideremarks { get; set; }

    public string? Supplementalmarkings { get; set; }
}
