using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Agenttodolist
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Taskid { get; set; }

    public int? Tasktype { get; set; }
}
