using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CasebaseSeqnr
{
    public string Seqname { get; set; } = null!;

    public long? Lastused { get; set; }
}
