using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmTransition
{
    public long? Id { get; set; }

    public long? StateFlowId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long? SourceStateId { get; set; }

    public long? DestinationStateId { get; set; }

    public string? Events { get; set; }

    public DateTime? CreatedDate { get; set; }
}
