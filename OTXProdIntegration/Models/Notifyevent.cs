using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Notifyevent
{
    public long? Eventseqno { get; set; }

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
}
