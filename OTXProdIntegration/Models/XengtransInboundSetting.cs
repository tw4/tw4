using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengtransInboundSetting
{
    public long? Dataid { get; set; }

    public byte? EnableInboundUpdates { get; set; }

    public string? InboundDocumentData { get; set; }

    public string? InboundActions { get; set; }
}
