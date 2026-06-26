using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapPoliciesUsr
{
    public long? PolicyId { get; set; }

    public long? Usr { get; set; }

    public string? ValidFrom { get; set; }

    public string? ValidTo { get; set; }

    public virtual OtsapPolicy Policy { get; set; } = null!;
}
