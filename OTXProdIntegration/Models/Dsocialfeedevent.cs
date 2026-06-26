using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsocialfeedevent
{
    public long? Nid { get; set; }

    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public long? Recipientid { get; set; }

    public long? Conversationid { get; set; }

    public long? Permid { get; set; }

    public long? Sgmdataid { get; set; }

    public short? Visible { get; set; }

    public byte? Visibletofollowers { get; set; }

    public byte? Eventtype { get; set; }

    public string? Eventinfo { get; set; }

    public DateTime? Modifieddate { get; set; }
}
