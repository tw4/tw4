using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class ControlledviewingPrinting
{
    public long? Seq { get; set; }

    public int? Status { get; set; }

    public long? Nodeid { get; set; }

    public long? Versionid { get; set; }

    public long? PrintedNodeid { get; set; }

    public long? PrintedVersionid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Errmsg { get; set; }

    public string? Reason { get; set; }
}
