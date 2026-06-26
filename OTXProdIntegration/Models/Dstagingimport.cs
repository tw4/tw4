using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dstagingimport
{
    public long? Nid { get; set; }

    public string Tagname { get; set; } = null!;

    public long? Dataid { get; set; }

    public long? Versionid { get; set; }

    public string? Chardata { get; set; }

    public long? Segmentid { get; set; }

    public string? Segment { get; set; }
}
