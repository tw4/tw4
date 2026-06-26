using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengtransRecipientDatum
{
    public long? Id { get; set; }

    public long? Dataid { get; set; }

    public long? Recipientid { get; set; }

    public string? RecipientMetadata { get; set; }

    public byte? DeliveryMethod { get; set; }

    public long? SentAttempt { get; set; }

    public byte? Status { get; set; }

    public string? StatusMessage { get; set; }

    public DateTime? SentTime { get; set; }

    public byte? Recipienttype { get; set; }
}
