using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Notifymessage
{
    public long? Messageseqno { get; set; }

    public byte? Interestlevel { get; set; }

    public long? Userid { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Eventsource { get; set; }

    public long? Eventid { get; set; }

    public long? Eventint1 { get; set; }

    public long? Eventint2 { get; set; }

    public short? Sortint1 { get; set; }

    public string Sortstr2 { get; set; } = null!;

    public short? Sortint3 { get; set; }

    public string? Message { get; set; }
}
