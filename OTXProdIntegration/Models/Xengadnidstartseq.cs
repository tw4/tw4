using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Xengadnidstartseq
{
    public long? Id { get; set; }

    public long? Documenttype { get; set; }

    public string Adnidpattern { get; set; } = null!;

    public long? InitialSeq { get; set; }
}
