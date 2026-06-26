using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapxecmPermissionpropagation
{
    public long? Tdataid { get; set; }

    public long? Csgroup { get; set; }

    public long? Templategroup { get; set; }

    public string Ruleexp { get; set; } = null!;

    public string Ruledata { get; set; } = null!;
}
