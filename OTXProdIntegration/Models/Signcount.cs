using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Signcount
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Taskid { get; set; }

    public int? Signedno { get; set; }

    public int? Signopt { get; set; }
}
