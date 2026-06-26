using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapxecmWkspSlink
{
    public string SotIdBo { get; set; } = null!;

    public int? IdBoType { get; set; }

    public long? Dataid { get; set; }

    public virtual OtsapSotType IdBoTypeNavigation { get; set; } = null!;
}
