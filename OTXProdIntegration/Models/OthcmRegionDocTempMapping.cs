using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmRegionDocTempMapping
{
    public string RegionName { get; set; } = null!;

    public string BoObjType { get; set; } = null!;

    public long? DocTemplId { get; set; }
}
