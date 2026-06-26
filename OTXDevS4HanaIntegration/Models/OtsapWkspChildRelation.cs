using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapWkspChildRelation
{
    public long? Dataid { get; set; }

    public long? RelatedWkspTypeId { get; set; }

    public long? RelatedDataId { get; set; }
}
