using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmInboxLog
{
    public long? Ticketno { get; set; }

    public short? Seqno { get; set; }

    public long? HrAdmin { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? ModifiedUser { get; set; }

    public string Status { get; set; } = null!;

    public string? Tcomment { get; set; }

    public string? AssignedTo { get; set; }

    public string? AssignedName { get; set; }

    public long? Classnodeid { get; set; }

    public long? LoggedinUserId { get; set; }
}
