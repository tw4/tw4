using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Blobresdatum
{
    public long? Ownerid { get; set; }

    public long? Longid { get; set; }

    public int? Segmentid { get; set; }

    public byte[]? Segment { get; set; }
}
