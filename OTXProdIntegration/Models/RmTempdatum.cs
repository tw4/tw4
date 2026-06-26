using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmTempdatum
{
    public string Tempkey { get; set; } = null!;

    public long? Nodeid { get; set; }

    public long? Userid { get; set; }

    public int? Permsmask { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Value1 { get; set; }
}
