using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapwkspRoleMapping
{
    public long? ParentDataid { get; set; }

    public long? ChildDataid { get; set; }

    public long? ParentRightid { get; set; }

    public long? ChildRightid { get; set; }
}
