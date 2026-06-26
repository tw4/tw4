using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdntSorulistesibakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Sorulistesitipi { get; set; }

    public string? Departman { get; set; }

    public string? No { get; set; }

    public string? Denetimsorusu { get; set; }

    public string? Soruaciklamasi { get; set; }

    public string? Standartadi1 { get; set; }

    public string? Standartadi1baglam { get; set; }

    public string? Standartadi2 { get; set; }

    public string? Standartadi2baglam { get; set; }

    public string? Standartadi3 { get; set; }

    public string? Standartadi3baglam { get; set; }

    public int? Aktif { get; set; }
}
