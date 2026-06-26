using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovForward
{
    public long? Forwardid { get; set; }

    public string Name { get; set; } = null!;

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Completedby { get; set; }

    public DateTime? Completedate { get; set; }

    public byte? Completed { get; set; }
}
