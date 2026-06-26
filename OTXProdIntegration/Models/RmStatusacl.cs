using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmStatusacl
{
    public string Status { get; set; } = null!;

    public long? Rightid { get; set; }

    public long? Permissions { get; set; }

    public int? Acltype { get; set; }
}
