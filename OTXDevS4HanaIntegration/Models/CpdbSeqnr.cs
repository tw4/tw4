using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CpdbSeqnr
{
    public string Seqname { get; set; } = null!;

    public long? Lastused { get; set; }
}
