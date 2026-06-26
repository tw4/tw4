using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dfacetkey
{
    public long? Id { get; set; }

    public string Keystr { get; set; } = null!;

    public string Hashstr { get; set; } = null!;
}
