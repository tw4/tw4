using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapBoTypesPropgroupMap
{
    public int? IdGroupCfg { get; set; }

    public int? IdBoType { get; set; }

    public string BoPropName { get; set; } = null!;

    public string AttName { get; set; } = null!;

    public virtual OtsapBoTypesPropgroup IdGroupCfgNavigation { get; set; } = null!;
}
