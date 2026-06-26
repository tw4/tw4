using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dshareitemreference
{
    public short? Itemtype { get; set; }

    public long? Csitemid { get; set; }

    public string? Cssubitemid { get; set; }

    public long? Csversionid { get; set; }

    public short? Providertype { get; set; }

    public string Provideritemid { get; set; } = null!;

    public string? Providersubitemid { get; set; }

    public string? Providerversionid { get; set; }
}
