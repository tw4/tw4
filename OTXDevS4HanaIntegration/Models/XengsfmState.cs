using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengsfmState
{
    public long? Id { get; set; }

    public long? StateflowId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public byte? InheritPermission { get; set; }

    public long? MinPerformersCount { get; set; }

    public long? StateOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? StateEnterWr { get; set; }

    public string? StateExitWr { get; set; }

    public long? TurnAroundDays { get; set; }
}
