using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapxecmWkspLink
{
    public int? IdBoType { get; set; }

    public string IdBo { get; set; } = null!;

    public long? Dataid { get; set; }

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
