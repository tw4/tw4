using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Lleventqueue
{
    public long? Eventseqno { get; set; }

    public long? Eventhandlerid { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Eventsource { get; set; }

    public long? Eventid { get; set; }

    public short? Eventaction { get; set; }

    public long? Eventint1 { get; set; }

    public long? Eventint2 { get; set; }

    public long? Eventint3 { get; set; }

    public long? Eventint4 { get; set; }

    public string? Eventstr5 { get; set; }

    public string? Eventstr6 { get; set; }

    public long? Userid { get; set; }
}
