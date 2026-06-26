using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessagebody
{
    public long? Id { get; set; }

    public long? Sourceid { get; set; }

    public int? Messagetype { get; set; }

    public string? Subject { get; set; }

    public string? Subjectdecoration { get; set; }

    public string Message { get; set; } = null!;

    public string? Shortmessage { get; set; }

    public string? Aggregatekey { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Expireson { get; set; }

    public string? Messagetoken { get; set; }
}
