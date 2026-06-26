using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmHoldqueryhistory
{
    public long? Eventid { get; set; }

    public long? Holdid { get; set; }

    public long? Queryid { get; set; }

    public string? Queryname { get; set; }

    public string? Comments { get; set; }

    public string? Querydetails { get; set; }

    public short? Action { get; set; }

    public DateTime? Auditdate { get; set; }

    public long? Audituser { get; set; }

    public long? Updateno { get; set; }
}
