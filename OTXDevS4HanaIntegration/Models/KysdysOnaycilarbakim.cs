using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdysOnaycilarbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Surectipi { get; set; }

    public long? Departman { get; set; }

    public long? Departmanbirimi { get; set; }

    public string? Dokumantipi { get; set; }

    public long? Kontroleden { get; set; }

    public long? Onayci1 { get; set; }

    public long? Onayci2 { get; set; }

    public long? Onayci3 { get; set; }

    public int? Aktif { get; set; }

    public int? Mailaktif { get; set; }

    public string? Mailadres { get; set; }
}
