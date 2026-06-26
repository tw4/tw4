using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapEventSubscription
{
    public long? Dataid { get; set; }

    public string Subscriber { get; set; } = null!;
}
