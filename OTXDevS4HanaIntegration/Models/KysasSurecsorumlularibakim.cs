using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysasSurecsorumlularibakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Sirketkodu { get; set; }

    public string? Departman { get; set; }

    public long? Departmangrup { get; set; }

    public string? Aksiyonsorumlusudepartman { get; set; }

    public long? Aksiyonsorumlusu { get; set; }

    public int? Aksiyonsorumlusuaktif { get; set; }

    public long? Aksiyonyoneticisi { get; set; }

    public int? Aksiyonyoneticisiaktif { get; set; }

    public long? Sistemsorumlusu { get; set; }

    public int? Sistemsorumlusuaktif { get; set; }

    public long? Ilgilibirimsorumlusu { get; set; }

    public int? Ilgilibirimsorumlusuaktif { get; set; }

    public long? Yonetimtemsilcisi { get; set; }

    public int? Yonetimtemsilcisiaktif { get; set; }
}
