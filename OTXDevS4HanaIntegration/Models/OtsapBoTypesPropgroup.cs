using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapBoTypesPropgroup
{
    public int? IdCfg { get; set; }

    public int? IdBoType { get; set; }

    public string BoPropGroupName { get; set; } = null!;

    public string CatCbName { get; set; } = null!;

    public string CatCbParm { get; set; } = null!;

    public string SetName { get; set; } = null!;

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
