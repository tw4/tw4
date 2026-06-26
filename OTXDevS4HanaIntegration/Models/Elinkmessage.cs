using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Elinkmessage
{
    public long? Msgid { get; set; }

    public string Tofield { get; set; } = null!;

    public string? Cc { get; set; }

    public string Fromfield { get; set; } = null!;

    public string Replyto { get; set; } = null!;

    public string Sender { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Xheaders { get; set; }

    public string? Message { get; set; }

    public long? Nodeattachment { get; set; }

    public string? Attachment { get; set; }
}
