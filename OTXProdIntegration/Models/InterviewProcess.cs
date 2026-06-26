using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class InterviewProcess
{
    public long? Locationid { get; set; }

    public string? Instanceid { get; set; }

    public int? Pf { get; set; }

    public int? Les { get; set; }

    public long? Destid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Ivdate { get; set; }

    public int? Processed { get; set; }
}
