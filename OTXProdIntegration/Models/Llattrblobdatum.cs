using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llattrblobdatum
{
    public long? Id { get; set; }

    public long? Vernum { get; set; }

    public int? Segmentid { get; set; }

    public string? Segmentblob { get; set; }
}
