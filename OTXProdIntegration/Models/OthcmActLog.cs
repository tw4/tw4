using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmActLog
{
    public long? Bwsnodeid { get; set; }

    public long? Childnodeid { get; set; }

    public long? Workflownodeid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? Subtype { get; set; }

    public string Activitytype { get; set; } = null!;

    public long? Classnodeid { get; set; }

    public long? Tmpnodeid { get; set; }

    public long? CreatedUser { get; set; }

    public string? Deleted { get; set; }

    public string? Documentname { get; set; }
}
