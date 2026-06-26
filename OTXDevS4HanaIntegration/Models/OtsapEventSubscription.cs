using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapEventSubscription
{
    public long? Dataid { get; set; }

    public string Subscriber { get; set; } = null!;
}
