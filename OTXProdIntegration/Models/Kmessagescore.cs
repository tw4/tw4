using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kmessagescore
{
    public long? Userid { get; set; }

    public long? Threadid { get; set; }

    public long? Sourceid { get; set; }

    public string? Hashtoken { get; set; }

    public int? State { get; set; }

    public int? Deleted { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Expireson { get; set; }

    public long? Total { get; set; }

    public long? Unread { get; set; }

    public long? Dirty { get; set; }
}
