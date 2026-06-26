using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengsfmStatusFlowAuditArchived
{
    public long? EventId { get; set; }

    public long? NodeId { get; set; }

    public long? StateFlowId { get; set; }

    public long? EventType { get; set; }

    public long? EventDetail { get; set; }

    public DateTime? EventDate { get; set; }

    public long? EventUser { get; set; }

    public string? PerformedOnbehalfof { get; set; }

    public string? Comments { get; set; }
}
