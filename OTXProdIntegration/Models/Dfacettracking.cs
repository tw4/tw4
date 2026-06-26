using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dfacettracking
{
    public long? Rowidnum { get; set; }

    public long? Taskid { get; set; }

    public string? Systemref { get; set; }

    public long? Dataid { get; set; }

    public DateTime? Taskdatestamp { get; set; }

    public string? Algorithm { get; set; }

    public string? Keys { get; set; }

    public string? Triggerstr { get; set; }

    public long? Timeinms { get; set; }

    public string? Spawned { get; set; }

    public string? Log { get; set; }
}
