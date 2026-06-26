using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengtransEmailSetting
{
    public long? EmailConfigId { get; set; }

    public byte? SenderEmailFlag { get; set; }

    public string? SenderEmail { get; set; }

    public string Subject { get; set; } = null!;

    public long? EmailBodyTemplateId { get; set; }
}
