using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CcmV
{
    public long? KontratCompoundId { get; set; }

    public string KontratCompoundAd { get; set; } = null!;

    public string KontratNumarasi { get; set; } = null!;

    public string? KontratRefNumarasi { get; set; }

    public string? HiyerarsiKod { get; set; }

    public string? HiyerarsiTanim { get; set; }

    public string? YurtIcDis { get; set; }

    public string? KategoriId { get; set; }

    public DateTime? KontratBaslangic { get; set; }

    public DateTime? KontratBitis { get; set; }

    public string? KontratGecerlilikSure { get; set; }

    public string? KontratTuru { get; set; }

    public DateTime? KontratImzaTarihi { get; set; }

    public string? TedarikciKodu { get; set; }

    public string? TedarikciUnvan { get; set; }

    public string? KontratTutari { get; set; }

    public string? DamgaVergisiTutari { get; set; }

    public long? TalepEden { get; set; }

    public long? TalepEdenDepartman { get; set; }

    public string? TalepEdenSirket { get; set; }

    public long? OtomatikYenileme { get; set; }

    public DateTime? AvukatAtamaTarihi { get; set; }

    public string? Gecerli { get; set; }

    public string? OtomatikYenilemeSuresi { get; set; }

    public long? KontratSorumlusu { get; set; }
}
