using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wfdisposition
{
    public long? WfWorkflowid { get; set; }

    public int? WfTaskid { get; set; }

    public string? WfValue { get; set; }
}
