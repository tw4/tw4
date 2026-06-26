using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdntSablonbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Sirketkodu { get; set; }

    public string? Denetimtipi { get; set; }

    public string? Denetimturu { get; set; }

    public string? Dntsablondokumanid { get; set; }

    public string? Dntsablondokumanadi { get; set; }

    public string? Dntsablonkisaltmasi { get; set; }

    public int? Aktif { get; set; }
}
