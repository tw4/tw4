using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovAssignmentrecipient
{
    public long? Assignmentid { get; set; }

    public long? Recipientid { get; set; }

    public long? Recipientgroupid { get; set; }

    public long? Addedby { get; set; }

    public DateTime? Adddate { get; set; }

    public string Status { get; set; } = null!;

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public byte? Completed { get; set; }
}
