using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Retentionupdateorder
{
    public long? Nid { get; set; }

    public long? Nodeid { get; set; }

    public string Retentionvalue { get; set; } = null!;

    public long? Count { get; set; }
}
