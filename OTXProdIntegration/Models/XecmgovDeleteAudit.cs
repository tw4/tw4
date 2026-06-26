using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovDeleteAudit
{
    public long? Dataid { get; set; }

    public string Name { get; set; } = null!;

    public long? Containerid { get; set; }
}
