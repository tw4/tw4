using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Workerqueuecurrent
{
    public long? Id { get; set; }

    public DateTime? Queuetime { get; set; }

    public long? Type { get; set; }

    public long? Priority { get; set; }

    public long? Attempts { get; set; }

    public string Handlerid { get; set; } = null!;

    public string Workerid { get; set; } = null!;

    public string Fingerprint { get; set; } = null!;

    public long? Status { get; set; }

    public DateTime? Workertime { get; set; }
}
