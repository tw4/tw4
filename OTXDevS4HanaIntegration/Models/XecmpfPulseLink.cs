using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfPulseLink
{
    public string IdExtsystem { get; set; } = null!;

    public long? NodeId { get; set; }

    public string? ExtsystemFeedId { get; set; }

    public long? RootNodeId { get; set; }
}
