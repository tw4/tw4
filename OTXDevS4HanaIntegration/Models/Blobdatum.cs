using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Blobdatum
{
    public long? Ownerid { get; set; }

    public long? Longid { get; set; }

    public int? Segmentid { get; set; }

    public byte[]? Segment { get; set; }
}
