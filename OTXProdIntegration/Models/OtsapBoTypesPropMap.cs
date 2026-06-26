using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapBoTypesPropMap
{
    public int? IdBoType { get; set; }

    public string BoPropName { get; set; } = null!;

    public string CatCbName { get; set; } = null!;

    public string CatCbParm { get; set; } = null!;

    public string AttName { get; set; } = null!;

    public string? SetName { get; set; }

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
