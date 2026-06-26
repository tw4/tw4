using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OiStatus
{
    public long? Id { get; set; }

    public long? NodesRead { get; set; }

    public long? TotalNodes { get; set; }

    public string? ImportFile { get; set; }

    public string? LogFile { get; set; }

    public string? ServerId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? Status { get; set; }
}
