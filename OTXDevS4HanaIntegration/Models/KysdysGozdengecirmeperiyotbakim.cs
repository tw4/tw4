using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdysGozdengecirmeperiyotbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Dokumangrubu { get; set; }

    public string? Dokumantipi { get; set; }

    public string? PeriyotAy { get; set; }

    public long? Sorumlu { get; set; }

    public string? Sorumluyoneticisi { get; set; }

    public int? Aktif { get; set; }

    public string? GozperiyotAy { get; set; }
}
