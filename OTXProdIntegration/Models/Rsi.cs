using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Rsi
{
    public string Rsi1 { get; set; } = null!;

    public string? Sortkey { get; set; }

    public string? RsititleE { get; set; }

    public string? RsititleF { get; set; }

    public string? RsisubjectE { get; set; }

    public string? RsisubjectF { get; set; }

    public string? RsidescE { get; set; }

    public string? RsidescF { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Rsistatus { get; set; }

    public DateTime? Statusdate { get; set; }

    public byte? Discontflag { get; set; }

    public DateTime? Discontdate { get; set; }

    public string? Discontcomment { get; set; }

    public string? Refrate { get; set; }

    public string? Vitalcode { get; set; }

    public string? Vitalstor { get; set; }

    public byte? Rsinoteflag { get; set; }

    public long? Retentionid { get; set; }

    public string? Active { get; set; }

    public decimal? Activeper { get; set; }

    public string? Dormant { get; set; }

    public decimal? Dormantper { get; set; }

    public string? Totalperiod { get; set; }

    public string? Disposition { get; set; }

    public byte? Archiveflag { get; set; }

    public string? Patron { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Receiveddate { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Archstatus { get; set; }

    public DateTime? Archstatusdate { get; set; }

    public string? Archcomment { get; set; }

    public byte? Archivalflag { get; set; }

    public string? BatchIndexFlag { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Editpatron { get; set; }

    public byte? RmRsi { get; set; }

    public string? Profileformcode { get; set; }

    public byte? Dispcontrol { get; set; }

    public long? Uniqueid { get; set; }
}
