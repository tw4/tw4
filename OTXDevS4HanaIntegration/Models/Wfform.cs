using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wfform
{
    public long? WfWorkflowid { get; set; }

    public int? WfFormid { get; set; }

    public string? WfValue { get; set; }
}
