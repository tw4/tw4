using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Rsiapprovalhistory
{
    public string Rsi { get; set; } = null!;

    public long? Rsischeduleid { get; set; }

    public DateTime? Approvaleditdate { get; set; }

    public long? Approvedbyuserid { get; set; }

    public DateTime? Approveddate { get; set; }

    public string? Approvalcomment { get; set; }

    public long? Approvaledituserid { get; set; }

    public DateTime? Removaleditdate { get; set; }

    public long? Removaledituserid { get; set; }
}
