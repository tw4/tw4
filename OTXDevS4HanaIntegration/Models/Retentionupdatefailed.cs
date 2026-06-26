using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Retentionupdatefailed
{
    public long? Nid { get; set; }

    public long? Nodeid { get; set; }

    public string Rmretention { get; set; } = null!;

    public DateTime? Failuretime { get; set; }
}
