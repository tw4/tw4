using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmPermission
{
    public long? Id { get; set; }

    public long? StateId { get; set; }

    public long? PerformerId { get; set; }

    public long? NodePermMask { get; set; }

    public byte? Watch { get; set; }

    public byte? Transition { get; set; }

    public byte? Override { get; set; }

    public byte? Assign { get; set; }

    public byte? PerformerType { get; set; }

    public string? ExtendedPerms { get; set; }
}
