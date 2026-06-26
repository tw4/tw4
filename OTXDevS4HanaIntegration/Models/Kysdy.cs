using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kysdy
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public long? Baslatankullanici { get; set; }

    public long? Baslatandepartman { get; set; }

    public string? Departmankodu { get; set; }

    public string? Sirketkodu { get; set; }

    public DateTime? Surecbaslatmatarihi { get; set; }

    public string? Yonetimsistemi { get; set; }

    public int? Yonetimsistemiaktif { get; set; }

    public string? Dokumantipi { get; set; }

    public string? Surectipi { get; set; }

    public DateTime? Ilkyayintarihi { get; set; }

    public DateTime? Revizyontarihi { get; set; }

    public DateTime? Gecerliliktarihi { get; set; }

    public string? Dysbelgenumarasi { get; set; }

    public string? Konu { get; set; }

    public string? Malzemekodu { get; set; }

    public string? Malzemekoducoklu { get; set; }

    public string? Ekipmankodu { get; set; }

    public string? Revizyonnumarasi { get; set; }

    public string? Sablonrevizyonnumarasi { get; set; }

    public string? Sablonsurecnumarasi { get; set; }

    public DateTime? Sablonrevizyontarihi { get; set; }

    public string? Ilgilibirim { get; set; }

    public string? Ilgilidisiplin { get; set; }

    public string? Aciklama { get; set; }

    public string? Gizlilikseviyesi { get; set; }

    public string? Karar { get; set; }

    public string? Wfdurum { get; set; }

    public string? Wfgorevform { get; set; }

    public string? Wfgonderenform { get; set; }

    public string? Dysdokid { get; set; }

    public string? Ydysdokid { get; set; }

    public string? Dyskid { get; set; }

    public string? Dysekid { get; set; }

    public string? Dyssablonid { get; set; }

    public string? Wfid { get; set; }

    public string? Wfattachkid { get; set; }

    public string? Wfeklerkid { get; set; }

    public string? Backupid { get; set; }

    public long? O1 { get; set; }

    public long? O2 { get; set; }

    public long? O3 { get; set; }

    public long? O4 { get; set; }

    public long? Kyssorumlusu { get; set; }

    public long? Dokumansorumlusu { get; set; }

    public long? Dokumanonayci { get; set; }

    public long? Ilgilibirimsorumlusu { get; set; }

    public long? Sononayci { get; set; }

    public long? Performer { get; set; }

    public long? Eskiperformer { get; set; }

    public string? Yorum { get; set; }

    public string? Ekalan1 { get; set; }

    public string? Ekalan2 { get; set; }

    public string? Yoneticimailadres { get; set; }

    public string? Dysdokumannumarasi { get; set; }
}
