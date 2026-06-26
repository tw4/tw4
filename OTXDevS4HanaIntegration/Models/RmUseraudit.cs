using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmUseraudit
{
    public long? Auditid { get; set; }

    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Auditdate { get; set; }

    public string? Event { get; set; }

    public string? Eventdesc { get; set; }
}
