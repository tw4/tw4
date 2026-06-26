using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovForwardrecipient
{
    public long? Forwardid { get; set; }

    public long? Recipientid { get; set; }

    public long? Recipientgroupid { get; set; }

    public long? Addedby { get; set; }

    public DateTime? Adddate { get; set; }

    public string? Directive { get; set; }

    public string? Notice { get; set; }

    public long? Completedby { get; set; }

    public DateTime? Completedate { get; set; }

    public byte? Completed { get; set; }
}
