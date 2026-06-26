using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Termlevel
{
    public string Termlevel1 { get; set; } = null!;

    public string? TermlevelDesc { get; set; }

    public int? Termlevelnumber { get; set; }

    public int? Termtype { get; set; }
}
