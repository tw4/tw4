using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Workerqueuecomplete
{
    public long? Id { get; set; }

    public DateTime? Queuetime { get; set; }

    public long? Type { get; set; }

    public long? Priority { get; set; }

    public long? Attempts { get; set; }

    public string Handlerid { get; set; } = null!;

    public string Result { get; set; } = null!;

    public string Fingerprint { get; set; } = null!;
}
