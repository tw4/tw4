using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Workerqueuepending
{
    public long? Id { get; set; }

    public DateTime? Queuetime { get; set; }

    public long? Type { get; set; }

    public long? Priority { get; set; }

    public long? Attempts { get; set; }

    public string Handlerid { get; set; } = null!;

    public string Fingerprint { get; set; } = null!;
}
