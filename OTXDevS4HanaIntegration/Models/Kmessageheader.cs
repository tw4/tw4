using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessageheader
{
    public long? Threadid { get; set; }

    public long? Sourceid { get; set; }

    public long? Userid { get; set; }

    public int? Messagetype { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Expireson { get; set; }

    public string? Subject { get; set; }

    public string? Subjectdecoration { get; set; }

    public string? Shortmessage { get; set; }

    public string Message { get; set; } = null!;

    public string? Hashtoken { get; set; }

    public int? State { get; set; }

    public long? Unread { get; set; }

    public long? Bodyid { get; set; }
}
