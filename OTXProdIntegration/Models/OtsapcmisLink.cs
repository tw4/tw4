using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapcmisLink
{
    public int? LinkTypeId { get; set; }

    public long? SrcId { get; set; }

    public long? DstId { get; set; }

    public string? SymDstId { get; set; }

    public string? LinkData { get; set; }
}
