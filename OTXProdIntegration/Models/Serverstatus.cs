using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Serverstatus
{
    public string Serverid { get; set; } = null!;

    public long? Timestamp { get; set; }

    public string? Servername { get; set; }
}
