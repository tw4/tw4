using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDeleteaudit
{
    public long? Auditid { get; set; }

    public long? Dataid { get; set; }

    public string? Name { get; set; }

    public long? Subtype { get; set; }

    public string? Mimetype { get; set; }

    public long? Createid { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Filenumber { get; set; }

    public string? Classname { get; set; }

    public string? Status { get; set; }

    public long? Requestid { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Officerid { get; set; }

    public DateTime? Officerdate { get; set; }

    public long? Authorityid { get; set; }

    public DateTime? Authorizationdate { get; set; }

    public string? Authcomment { get; set; }

    public byte? Workflowdelete { get; set; }

    public string? Rsi { get; set; }

    public int? Rimsstatusdate { get; set; }

    public long? Owner { get; set; }

    public string? Dispauthority { get; set; }

    public int? Rimsdocdate { get; set; }

    public string? Filename { get; set; }

    public byte? Dispdestroy { get; set; }

    public string? Accession { get; set; }

    public string? Essential { get; set; }

    public string? Storage { get; set; }

    public string? Keywords { get; set; }

    public string? Subject { get; set; }

    public short? Cycleperiod { get; set; }

    public byte? Closedflag { get; set; }

    public int? Closeddate { get; set; }

    public int? Lastadditiondate { get; set; }

    public byte? Official { get; set; }

    public int? Rimsnextreviewdate { get; set; }

    public int? Rimslastreviewdate { get; set; }

    public int? Rimsreceiveddate { get; set; }

    public string? Rimsaddressee { get; set; }

    public string? Rimsestablishment { get; set; }

    public string? Rimsoriginator { get; set; }

    public string? Rimssentto { get; set; }

    public long? Dispnodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public long? Classid { get; set; }

    public long? Approverid { get; set; }

    public DateTime? Approveddate { get; set; }

    public long? Versionnum { get; set; }

    public DateTime? Externalcreatedate { get; set; }
}
