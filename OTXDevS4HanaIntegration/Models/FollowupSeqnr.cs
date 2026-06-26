using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class FollowupSeqnr
{
    public string Seqname { get; set; } = null!;

    public long? Lastused { get; set; }
}
