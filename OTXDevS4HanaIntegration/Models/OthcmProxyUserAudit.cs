using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmProxyUserAudit
{
    public long? ProxyUserId { get; set; }

    public long? LoggedinUserId { get; set; }

    public long? EventId { get; set; }
}
