using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kyskry
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public long? Baslatankullanici { get; set; }

    public long? Baslatandepartman { get; set; }

    public DateTime? Surecbaslatmatarihi { get; set; }

    public string? Surecnumarasi { get; set; }

    public string? Periyot { get; set; }

    public DateTime? Gozdengecirmetarihi { get; set; }

    public DateTime? Planlanangozdengecirmetarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? Yorum { get; set; }

    public string? Karar { get; set; }

    public string? Wfdurum { get; set; }

    public string? Wfgorevform { get; set; }

    public string? Wfgonderenform { get; set; }

    public string? Wfid { get; set; }

    public string? Wfattachkid { get; set; }

    public string? Wfeklerkid { get; set; }

    public string? Dokid { get; set; }

    public string? Kid { get; set; }

    public string? Departman { get; set; }

    public long? Departmansorumlusu { get; set; }

    public long? Departmankullanicilari { get; set; }

    public long? Performer { get; set; }

    public long? Eskiperformer { get; set; }

    public string? Ekalan1 { get; set; }

    public string? Ekalan2 { get; set; }

    public long? Ekalan3 { get; set; }

    public string? Egisgwfid { get; set; }

    public string? Egdfwfid { get; set; }

    public string? Egyggwfid { get; set; }

    public string? Egaswfid { get; set; }

    public string? Egkrywfid { get; set; }

    public string? Egdgsmwfid { get; set; }

    public string? Egymuywfid { get; set; }
}
