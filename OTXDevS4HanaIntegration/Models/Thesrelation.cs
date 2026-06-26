using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Thesrelation
{
    public long? Termid1 { get; set; }

    public string Relattype { get; set; } = null!;

    public long? Termid2 { get; set; }
}
