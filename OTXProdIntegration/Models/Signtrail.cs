using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Signtrail
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public string Workflowname { get; set; } = null!;

    public DateTime? Signeddate { get; set; }

    public string Signedby { get; set; } = null!;

    public long? Userid { get; set; }

    public string? Title { get; set; }

    public string? Meaning { get; set; }

    public int? Appendedpage { get; set; }

    public int? Srctrail { get; set; }

    public long? Docid { get; set; }
}
