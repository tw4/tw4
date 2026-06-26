using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Licecosystem
{
    public long? Ecosystemid { get; set; }

    public string Name { get; set; } = null!;

    public long? Subtype { get; set; }

    public string Nameresid { get; set; } = null!;
}
