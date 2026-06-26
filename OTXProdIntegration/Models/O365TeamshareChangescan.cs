using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class O365TeamshareChangescan
{
    public string Tenant { get; set; } = null!;

    public string Teamid { get; set; } = null!;

    public string Channelid { get; set; } = null!;

    public string Driveid { get; set; } = null!;

    public string Itemid { get; set; } = null!;

    public long? Csnodeid { get; set; }

    public DateTime? Lastmodified { get; set; }

    public string Deltatoken { get; set; } = null!;

    public short? Scanstatus { get; set; }

    public short? Failurecount { get; set; }

    public string? Subscriptionid { get; set; }

    public string? Extradata { get; set; }
}
