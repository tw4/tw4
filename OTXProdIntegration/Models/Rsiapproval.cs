using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Rsiapproval
{
    public string Rsi { get; set; } = null!;

    public long? Rsischeduleid { get; set; }

    public long? Approvedbyuserid { get; set; }

    public DateTime? Approveddate { get; set; }

    public string? Approvalcomment { get; set; }

    public DateTime? Approvaleditdate { get; set; }

    public long? Approvaledituserid { get; set; }
}
