using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Timedue
{
    public long? Userid { get; set; }

    public DateTime? Expdate { get; set; }

    public string? Ip { get; set; }
}
