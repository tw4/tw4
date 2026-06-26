using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KyskrySurecsorumlularibakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Departmanlar { get; set; }

    public string? Departman { get; set; }

    public long? Departmangrup { get; set; }

    public long? Surecibaslatankullanici { get; set; }

    public int? Surecibaslatankullaniciaktif { get; set; }

    public long? Departmankullanicilari { get; set; }

    public int? Departmankullanicilariaktif { get; set; }

    public long? Departmansorumlusu { get; set; }

    public int? Departmansorumlusuaktif { get; set; }

    public long? Ilgilibirimsorumlusu { get; set; }

    public int? Ilgilibirimsorumlusuaktif { get; set; }
}
