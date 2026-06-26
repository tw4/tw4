using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmDeleteauditmetadatum
{
    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public string Tabtype { get; set; } = null!;

    public string? Tabmetadata { get; set; }
}
