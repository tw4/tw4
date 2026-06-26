using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dauditnewcore
{
    public long? Eventid { get; set; }

    public int? Auditid { get; set; }

    public string Auditstr { get; set; } = null!;

    public DateTime? Auditdate { get; set; }

    public long? Dataid { get; set; }

    public int? Subtype { get; set; }

    public long? Userid { get; set; }

    public long? Performerid { get; set; }

    public long? Agentid { get; set; }

    public string? Valuekey { get; set; }

    public string? Value1 { get; set; }

    public string? Value2 { get; set; }

    public string? Applicationid { get; set; }

    public string? Languagecode { get; set; }

    public long? Targetuserid { get; set; }
}
