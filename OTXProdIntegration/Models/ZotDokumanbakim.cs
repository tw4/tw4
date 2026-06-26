using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class ZotDokumanbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Dokumantur { get; set; }

    public string? Dokumangrup { get; set; }

    public int? Gecerli { get; set; }

    public int? Dysdokumani { get; set; }

    public string? Kod { get; set; }
}
