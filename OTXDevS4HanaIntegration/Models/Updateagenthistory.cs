using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Updateagenthistory
{
    public string? AgentId { get; set; }

    public byte? EventType { get; set; }

    public DateTime? EventDate { get; set; }

    public string? EventResult { get; set; }

    public string? EventSource { get; set; }

    public string? EventMetadata { get; set; }
}
