using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Lluserdatum
{
    public long? Prefsid { get; set; }

    public string Prefskeyword { get; set; } = null!;

    public DateTime? Lastupdatedate { get; set; }

    public string? Prefsvalue { get; set; }
}
