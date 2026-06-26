using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Rimsnodeclassification
{
    public long? Nodeid { get; set; }

    public string? Rimsaccession { get; set; }

    public string? Rimsaddressee { get; set; }

    public string? Rimssubject { get; set; }

    public string? Rimsclassification { get; set; }

    public int? Rimsdocdate { get; set; }

    public string? Rimsessential { get; set; }

    public string? Rimsestablishment { get; set; }

    public string? Rimsmediatype { get; set; }

    public byte? Rimsofficial { get; set; }

    public string? Rimsoriginator { get; set; }

    public string? Rimsretstage { get; set; }

    public string? Rimsrsi { get; set; }

    public string? Rimssentto { get; set; }

    public int? Rimsstagedate { get; set; }

    public string? Rimsstatus { get; set; }

    public int? Rimsstatusdate { get; set; }

    public string? Rimsstorage { get; set; }

    public long? Classid { get; set; }

    public short? Rimscycleperiod { get; set; }

    public int? Rimsnextreviewdate { get; set; }

    public int? Rimslastreviewdate { get; set; }

    public int? Rimsreceiveddate { get; set; }
}
