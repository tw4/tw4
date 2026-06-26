using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapwkspInstRoleMapping
{
    public long? InstanceDataid { get; set; }

    public long? TemplateRightid { get; set; }

    public long? InstanceRightid { get; set; }

    public int? IsLinkedRight { get; set; }
}
