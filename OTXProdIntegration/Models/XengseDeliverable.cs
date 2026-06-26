using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengseDeliverable
{
    public long? Id { get; set; }

    public string? SeDeliverableId { get; set; }

    public string? SeDeliverableDocName { get; set; }

    public string? SeDeliverableDocVersion { get; set; }

    public string? SeDeliverableStatus { get; set; }

    public string? SeDeliverableListId { get; set; }
}
