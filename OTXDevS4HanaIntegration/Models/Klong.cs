using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Klong
{
    public long? Ownerid { get; set; }

    public long? Longid { get; set; }

    public int? Segmentid { get; set; }

    public string Segment { get; set; } = null!;
}
