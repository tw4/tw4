using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dfacetkey
{
    public long? Id { get; set; }

    public string Keystr { get; set; } = null!;

    public string Hashstr { get; set; } = null!;
}
