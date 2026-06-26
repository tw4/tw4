using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmRule
{
    public string RoleName { get; set; } = null!;

    public long? RuleId { get; set; }

    public string? TargetGroupLevel { get; set; }

    public string? Status { get; set; }

    public string? ExcludeSelf { get; set; }

    public string? RelationRole { get; set; }

    public string? MyFilter { get; set; }
}
