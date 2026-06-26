using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xecmpfccreviewticket
{
    public long? Ticketid { get; set; }

    public byte? Ticketstatus { get; set; }

    public long? Workspaceid { get; set; }

    public long? Docid { get; set; }

    public long? Classid { get; set; }

    public long? Workflowid { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }
}
