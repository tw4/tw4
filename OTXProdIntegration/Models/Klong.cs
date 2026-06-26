using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Klong
{
    public long? Ownerid { get; set; }

    public long? Longid { get; set; }

    public int? Segmentid { get; set; }

    public string Segment { get; set; } = null!;
}
