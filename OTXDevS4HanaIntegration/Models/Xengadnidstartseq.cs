using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengadnidstartseq
{
    public long? Id { get; set; }

    public long? Documenttype { get; set; }

    public string Adnidpattern { get; set; } = null!;

    public long? InitialSeq { get; set; }
}
