using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Itemrefdatum
{
    public long? Seqno { get; set; }

    public long? Docid { get; set; }

    public long? Versionnum { get; set; }

    public int? Reftype { get; set; }
}
