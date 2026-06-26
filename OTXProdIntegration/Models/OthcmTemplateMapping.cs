using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmTemplateMapping
{
    public long? IdBoType { get; set; }

    public long? DocTemplId { get; set; }

    public string Ruleexp { get; set; } = null!;

    public string Ruledata { get; set; } = null!;

    public long? Priority { get; set; }
}
