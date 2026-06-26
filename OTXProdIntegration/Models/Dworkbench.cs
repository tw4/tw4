using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dworkbench
{
    public long? Dataid { get; set; }

    public DateTime? Readydate { get; set; }

    public byte[]? Objectguid { get; set; }

    public byte[]? Versionguid { get; set; }
}
