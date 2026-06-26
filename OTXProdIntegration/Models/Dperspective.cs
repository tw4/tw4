using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dperspective
{
    public long? Ownerid { get; set; }

    public long? Dataid { get; set; }

    public long? Parentid { get; set; }

    public long? Versionnum { get; set; }

    public string Perspectivetype { get; set; } = null!;

    public long? Appliestoid { get; set; }

    public long? Ordering { get; set; }

    public long? Ruleid { get; set; }

    public long? Assetcontainerid { get; set; }

    public byte? Cascadevalue { get; set; }

    public string? Perspectiveinfo { get; set; }

    public byte? Enabled { get; set; }
}
