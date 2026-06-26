using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfeacEvent
{
    public long? EventId { get; set; }

    public long? PlanId { get; set; }

    public short? EventPosition { get; set; }

    public string EventData { get; set; } = null!;
}
