using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovCloseditem
{
    public long? Dataid { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Oldrmstatus { get; set; }

    public string? Newrmstatus { get; set; }
}
