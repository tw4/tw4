using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CcmTempKontratdurumbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? KontratDurum { get; set; }

    public int? Aktif { get; set; }
}
