using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wopisession
{
    public long? Nodeid { get; set; }

    public long? Originalverid { get; set; }

    public DateTime? Sessionstart { get; set; }

    public string Lockid { get; set; } = null!;

    public DateTime? Wopilockts { get; set; }

    public long? Sessionid { get; set; }
}
