using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wfcomment
{
    public long? WfWorkflowid { get; set; }

    public int? WfTaskid { get; set; }

    public string? WfValue { get; set; }

    public DateTime? WfDatesaved { get; set; }

    public int? WfSequence { get; set; }

    public long? WfPerformerid { get; set; }

    public long? WfCommentid { get; set; }
}
