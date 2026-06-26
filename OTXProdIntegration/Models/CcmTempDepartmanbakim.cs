using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CcmTempDepartmanbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Sirketkodu { get; set; }

    public string? Departman { get; set; }

    public long? DepartmanGrup { get; set; }

    public string? MasrafYeri { get; set; }

    public long? DepartmanSorumlu { get; set; }

    public long? DepartmanYonetici { get; set; }

    public long? Gmy { get; set; }

    public long? Gm { get; set; }

    public int? SoruListesiHaric { get; set; }

    public int? Aktif { get; set; }
}
