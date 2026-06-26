using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfAppintgnActInfo
{
    public string Activityinstanceguid { get; set; } = null!;

    public long? Activityinstanceid { get; set; }

    public long? Actvityflowid { get; set; }

    public string Activityflowtitle { get; set; } = null!;

    public long? Bwsdataid { get; set; }

    public long? Taskscount { get; set; }

    public string? Activityuserdata { get; set; }

    public int? Status { get; set; }

    public DateTime? Initiateddate { get; set; }

    public long? Initiatedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Terminateddate { get; set; }

    public long? Terminatedby { get; set; }

    public byte? Workflowtype { get; set; }
}
