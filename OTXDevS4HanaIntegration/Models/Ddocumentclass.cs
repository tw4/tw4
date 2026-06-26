using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ddocumentclass
{
    public long? Nid { get; set; }

    public string Name { get; set; } = null!;

    public int? Type { get; set; }
}
