using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Agenttodolist
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Taskid { get; set; }

    public int? Tasktype { get; set; }
}
