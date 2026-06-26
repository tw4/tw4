using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmProxyUserAudit
{
    public long? ProxyUserId { get; set; }

    public long? LoggedinUserId { get; set; }

    public long? EventId { get; set; }
}
