using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Workerqueueerror
{
    public long? Id { get; set; }

    public DateTime? Queuetime { get; set; }

    public long? Type { get; set; }

    public long? Priority { get; set; }

    public long? Attempts { get; set; }

    public string? Handlerid { get; set; }

    public string? Workerid { get; set; }

    public string? Fingerprint { get; set; }

    public long? Status { get; set; }

    public DateTime? Workertime { get; set; }

    public DateTime? Errortime { get; set; }

    public string? Description { get; set; }

    public long? Userid { get; set; }

    public long? Parentid { get; set; }
}
