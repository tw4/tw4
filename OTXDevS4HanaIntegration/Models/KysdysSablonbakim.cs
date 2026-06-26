using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdysSablonbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Sirketkodu { get; set; }

    public string? Dokumangrubu { get; set; }

    public string? Dyssablontipi { get; set; }

    public string? Dyssablondokumanid { get; set; }

    public string? Dyssablondokumanadi { get; set; }

    public string? Dyssablonkisaltmasi { get; set; }

    public int? Aktif { get; set; }

    public int? Urunkoduaktif { get; set; }

    public int? Ekipmankoduaktif { get; set; }

    public int? Ortaksablon { get; set; }

    public int? Yonetimsistemi { get; set; }
}
