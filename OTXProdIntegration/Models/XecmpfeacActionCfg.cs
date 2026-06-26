using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfeacActionCfg
{
    public long? CfgId { get; set; }

    public long? PlanId { get; set; }

    public short? CfgPosition { get; set; }

    public string ActionKey { get; set; } = null!;

    public byte? DependsOn { get; set; }
}
