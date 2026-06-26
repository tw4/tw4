using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class KysdysDepartmanbirimbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Departmankodu { get; set; }

    public long? Departman { get; set; }

    public string? Departmanadi { get; set; }

    public string? Birimkodu { get; set; }

    public long? Birim { get; set; }

    public string? Birimadi { get; set; }

    public int? Aktif { get; set; }

    public int? Birimaktif { get; set; }
}
