using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llcache
{
    public long? Objectid { get; set; }

    public long? Segmentid { get; set; }

    public string? Segmentblob { get; set; }

    public DateTime? Objectdate { get; set; }
}
