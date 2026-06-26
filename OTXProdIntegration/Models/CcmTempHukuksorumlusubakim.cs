using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CcmTempHukuksorumlusubakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? YurticiYurtdisi { get; set; }

    public long? Kullanici { get; set; }

    public string? AdSoyad { get; set; }

    public string? Title { get; set; }

    public string? Cc1Yonetici { get; set; }

    public string? Cc2Yonetici { get; set; }

    public int? Aktif { get; set; }

    public int? Hukuksorumlusu { get; set; }
}
