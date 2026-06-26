using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreesyncevent
{
    public long? Eventseqno { get; set; }

    public DateTime? Eventdate { get; set; }

    public int? Eventid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Ownerid { get; set; }

    public int? Subtype { get; set; }

    public string? Params { get; set; }
}
