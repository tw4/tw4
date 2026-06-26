using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wfformsversion
{
    public long? WfWorkflowid { get; set; }

    public int? WfTaskid { get; set; }

    public int? WfFormid { get; set; }

    public string? WfValue { get; set; }

    public long? WfSubworkid { get; set; }
}
