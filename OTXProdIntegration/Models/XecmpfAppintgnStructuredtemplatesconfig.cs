using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfAppintgnStructuredtemplatesconfig
{
    public string Structuredwftemplateid { get; set; } = null!;

    public long? Templatedataid { get; set; }

    public string? Swfuserdata { get; set; }

    public long? Status { get; set; }

    public DateTime? Modifydate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Createdby { get; set; }
}
