using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmsecDefinedrule
{
    public long? Ruleid { get; set; }

    public long? Nodeid { get; set; }

    public byte? Ruleaction { get; set; }

    public DateTime? Ruledate { get; set; }

    public string Rulevalue { get; set; } = null!;

    public string? Rulereason { get; set; }

    public int? Processed { get; set; }
}
