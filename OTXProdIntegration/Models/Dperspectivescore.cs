using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dperspectivescore
{
    public long? Dataid { get; set; }

    public string Perspectivetype { get; set; } = null!;

    public long? Appliestoid { get; set; }

    public long? Ordering { get; set; }

    public long? Assetcontainerid { get; set; }

    public byte? Cascadevalue { get; set; }

    public string? Perspectiveinfo { get; set; }

    public byte? Enabled { get; set; }
}
