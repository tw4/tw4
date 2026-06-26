using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdntDenetimplanlari
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public long? Denetimiplanlayankullanici { get; set; }

    public long? Denetimiplanlayandepartman { get; set; }

    public DateTime? Planbaslangictarihi { get; set; }

    public DateTime? Planbitistarihi { get; set; }

    public string? Sirketkodu { get; set; }

    public string? Denetcibilgilendirmesuresi { get; set; }

    public string? Denetlenenbilgilendirmesuresi { get; set; }

    public string? Denetimtipi { get; set; }

    public string? Denetimturu { get; set; }

    public string? Denetimhedefi { get; set; }

    public string? Toplamdenetimsuresi { get; set; }

    public string? Tedarikciadi { get; set; }

    public string? Denetlenecekurungrubu { get; set; }

    public string? Planbilgilendirilecekuyeler { get; set; }

    public string? Plantanimi { get; set; }

    public string? Planno { get; set; }

    public string? Periyot { get; set; }

    public string? Plandurumu { get; set; }

    public string? Aciklama { get; set; }

    public string? Periyotgun { get; set; }

    public long? Denetci { get; set; }

    public string? Disdenetci { get; set; }

    public string? Denetimekibi { get; set; }

    public string? Denetimekibinonotx { get; set; }

    public string? Denetlenecekdepartman { get; set; }

    public long? Denetlenecekdepartmansorumlusu { get; set; }

    public long? Kysmuduru { get; set; }

    public string? Denetimsablondokumani { get; set; }

    public string? Ekalan1 { get; set; }

    public string? Ekalan2 { get; set; }

    public long? Ekalan3 { get; set; }
}
