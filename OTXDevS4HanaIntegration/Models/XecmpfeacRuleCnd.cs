using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfeacRuleCnd
{
    public long? RuleId { get; set; }

    public short? CndPosition { get; set; }

    public string CndOperand { get; set; } = null!;

    public string CndOperation { get; set; } = null!;

    public string CndValue { get; set; } = null!;

    public string? CndLogicalConnective { get; set; }
}
