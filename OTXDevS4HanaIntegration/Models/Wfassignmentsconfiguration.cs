using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wfassignmentsconfiguration
{
    public long? Configurationid { get; set; }

    public long? Workflowmapid { get; set; }

    public int? Statustype { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string Configdisplayname { get; set; } = null!;

    public string Configurationuserdata { get; set; } = null!;

    public string? Configdisplaynamelocalized { get; set; }

    public string? Purpose { get; set; }

    public string? Configadditionaldata { get; set; }
}
