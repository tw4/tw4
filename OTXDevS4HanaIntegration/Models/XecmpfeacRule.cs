using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfeacRule
{
    public long? RuleId { get; set; }

    public long? PlanId { get; set; }

    public string EventNamespace { get; set; } = null!;

    public string EventType { get; set; } = null!;

    public string EventName { get; set; } = null!;
}
