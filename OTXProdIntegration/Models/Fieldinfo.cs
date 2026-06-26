using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Fieldinfo
{
    public long? Workid { get; set; }

    public string Fname { get; set; } = null!;

    public int? Toppos { get; set; }

    public int? Leftpos { get; set; }
}
