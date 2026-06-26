using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapwkspBoChildRelation
{
    public int? IdBoType { get; set; }

    public string IdBo { get; set; } = null!;

    public long? Dataid { get; set; }

    public int? RelatedIdBoType { get; set; }

    public string RelatedIdBo { get; set; } = null!;

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;

    public virtual OtsapBoTypesCore RelatedIdBoTypeNavigation { get; set; } = null!;
}
