using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Liclevel
{
    public long? Levelid { get; set; }

    public string Name { get; set; } = null!;

    public int? Priority { get; set; }

    public int? Maxaccessdays { get; set; }

    public string Seller { get; set; } = null!;

    public string Nameresid { get; set; } = null!;

    public long? Ecosystemid { get; set; }
}
