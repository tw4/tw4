using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdntSurecsorumlularibakim
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

    public long? Kyssorumlusu { get; set; }

    public int? Kyssorumlusuaktif { get; set; }

    public long? Yonetimtemsilcisorumlusu { get; set; }

    public int? Yonetimtemsilcisorumlusuaktif { get; set; }

    public long? Denetimdepartmansorumlusu { get; set; }

    public int? Denetimdepartmansorumlusuaktif { get; set; }

    public long? Ilgilibirimsorumlusu { get; set; }

    public int? Ilgilibirimsorumlusuaktif { get; set; }

    public string? Denetlenecekdepartman { get; set; }

    public int? Denetlenecekdepartmanaktif { get; set; }
}
