using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Elinkalias
{
    public long? Objectid { get; set; }

    public int? Objectidtype { get; set; }

    public string Emailalias { get; set; } = null!;
}
