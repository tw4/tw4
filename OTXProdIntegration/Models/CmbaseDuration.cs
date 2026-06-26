using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CmbaseDuration
{
    public long? Dataid { get; set; }

    public DateTime? Effective { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Earlyterm { get; set; }

    public int? Terminated { get; set; }

    public string? Data { get; set; }

    public DateTime? Versiondate { get; set; }

    public int? Currentver { get; set; }
}
