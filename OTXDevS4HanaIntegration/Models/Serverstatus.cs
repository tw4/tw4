using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Serverstatus
{
    public string Serverid { get; set; } = null!;

    public long? Timestamp { get; set; }

    public string? Servername { get; set; }
}
