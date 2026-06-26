using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapWkspRelation
{
    public int? IdWkspType { get; set; }

    public long? Dataid { get; set; }

    public int? RelatedIdWkspType { get; set; }

    public long? RelatedDataid { get; set; }

    public virtual OtsapRefType IdWkspTypeNavigation { get; set; } = null!;

    public virtual OtsapRefType RelatedIdWkspTypeNavigation { get; set; } = null!;
}
