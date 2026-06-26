using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovxdomeaSelectiondatum
{
    public long? Jobid { get; set; }

    public long? Recdataid { get; set; }

    public string Recguid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Selectiontype { get; set; }
}
