using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class O365teamshareitemmap
{
    public string Tenant { get; set; } = null!;

    public string Drivekey { get; set; } = null!;

    public string Driveitemkey { get; set; } = null!;

    public string? Parentdriveitemkey { get; set; }

    public string Sitekey { get; set; } = null!;

    public string Listkey { get; set; } = null!;

    public long? Listitemkey { get; set; }

    public string Itemtype { get; set; } = null!;
}
