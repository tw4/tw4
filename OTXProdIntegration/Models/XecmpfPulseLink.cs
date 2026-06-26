using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfPulseLink
{
    public string IdExtsystem { get; set; } = null!;

    public long? NodeId { get; set; }

    public string? ExtsystemFeedId { get; set; }

    public long? RootNodeId { get; set; }
}
