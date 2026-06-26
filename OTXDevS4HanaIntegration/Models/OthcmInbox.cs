using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmInbox
{
    public long? Ticketno { get; set; }

    public long? HrAdmin { get; set; }

    public long? Docnodeid { get; set; }

    public string Channel { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public long? CreatedUser { get; set; }

    public string Subject { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Tcomment { get; set; }

    public string? AssignedTo { get; set; }

    public string? AssignedName { get; set; }

    public DateTime? DateOfOrigin { get; set; }

    public long? Classnodeid { get; set; }

    public long? Tmpnodeid { get; set; }

    public long? Bwsnodeid { get; set; }
}
