using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovAssignmentstatus
{
    public string Status { get; set; } = null!;

    public byte? Defaultstatus { get; set; }

    public byte? Terminationstatus { get; set; }

    public long? Deletedby { get; set; }

    public DateTime? Deletedate { get; set; }

    public byte? Deleted { get; set; }
}
