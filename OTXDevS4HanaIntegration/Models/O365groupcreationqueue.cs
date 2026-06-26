using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class O365groupcreationqueue
{
    public long? Jobid { get; set; }

    public string Taskdata { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public DateTime? Lastruntimestamp { get; set; }

    public long? Attempts { get; set; }

    public string? Status { get; set; }

    public string? Details { get; set; }
}
