using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmStateFlowMapping
{
    public long? Dataid { get; set; }

    public long? WorkspaceId { get; set; }

    public long? StateflowAdmin { get; set; }

    public byte? Status { get; set; }

    public byte? DisplayCustomColumns { get; set; }

    public long? TurnAroundDays { get; set; }

    public long? Ddmid { get; set; }
}
