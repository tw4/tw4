using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfAppintgnTaskActInfo
{
    public long? Activityinstanceid { get; set; }

    public long? Taskid { get; set; }

    public string Activitytaskevent { get; set; } = null!;

    public string? Eventmessage { get; set; }

    public long? Performedby { get; set; }

    public DateTime? Performeddate { get; set; }

    public string? Taskeventuserdata { get; set; }
}
