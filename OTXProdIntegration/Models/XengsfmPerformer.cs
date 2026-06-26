using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmPerformer
{
    public long? Id { get; set; }

    public long? NodeId { get; set; }

    public long? PerformerId { get; set; }

    public byte? Watch { get; set; }

    public byte? Transition { get; set; }

    public byte? Override { get; set; }

    public byte? Assign { get; set; }

    public string? ExtendedPerms { get; set; }

    public string? ClaimedFrom { get; set; }

    public byte? IsApproved { get; set; }

    public long? TransitionId { get; set; }
}
