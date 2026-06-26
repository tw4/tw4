using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmStateFlow
{
    public long? NodeId { get; set; }

    public long? StateFlowId { get; set; }

    public long? StateId { get; set; }

    public long? NextTransition { get; set; }

    public DateTime? AssociatedDate { get; set; }

    public DateTime? PlannedEndDate { get; set; }

    public DateTime? ForecastDate { get; set; }
}
