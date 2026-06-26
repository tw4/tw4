using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapSotType
{
    public string SotType { get; set; } = null!;

    public int? IdBoType { get; set; }

    public virtual ICollection<OtsapxecmWkspSlink> OtsapxecmWkspSlinks { get; set; } = new List<OtsapxecmWkspSlink>();
}
