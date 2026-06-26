using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class O365TeamshareChange
{
    public string Tenant { get; set; } = null!;

    public string Driveid { get; set; } = null!;

    public string Itemid { get; set; } = null!;

    public string? Itemname { get; set; }

    public string Itemtype { get; set; } = null!;

    public string Changetype { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string? Modifiedby { get; set; }

    public string? Parentitemid { get; set; }

    public string? Hashcode { get; set; }

    public string? Verifystatus { get; set; }

    public string? Itempath { get; set; }
}
