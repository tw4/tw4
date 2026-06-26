using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Elinkalias
{
    public long? Objectid { get; set; }

    public int? Objectidtype { get; set; }

    public string Emailalias { get; set; } = null!;
}
