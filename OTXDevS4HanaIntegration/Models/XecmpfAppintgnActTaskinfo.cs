using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfAppintgnActTaskinfo
{
    public string Taskguid { get; set; } = null!;

    public long? Parenttaskid { get; set; }

    public long? Activityinstanceid { get; set; }

    public long? Taskid { get; set; }

    public string Tasktitle { get; set; } = null!;

    public long? Taskassigneeid { get; set; }

    public string? Taskuserdata { get; set; }

    public int? Status { get; set; }

    public long? Target { get; set; }

    public short? Targettype { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }
}
