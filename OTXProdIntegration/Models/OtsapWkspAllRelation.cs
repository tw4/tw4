using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapWkspAllRelation
{
    public long? Dataid { get; set; }

    public long? RelatedWkspTypeId { get; set; }

    public long? RelatedDataId { get; set; }
}
