using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapxecmWkspNolink
{
    public long? Dataid { get; set; }

    public int? IdReferenceType { get; set; }

    public virtual OtsapRefType IdReferenceTypeNavigation { get; set; } = null!;
}
