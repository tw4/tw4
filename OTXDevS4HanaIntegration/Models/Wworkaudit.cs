using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wworkaudit
{
    public long? WorkauditWorkid { get; set; }

    public long? WorkauditAuditid { get; set; }

    public long? WorkauditSubworkid { get; set; }

    public int? WorkauditTaskid { get; set; }

    public long? WorkauditPerformerid { get; set; }

    public DateTime? WorkauditDate { get; set; }

    public int? WorkauditStatus { get; set; }

    public string? WorkauditUserdata { get; set; }

    public int? WorkauditTaskiternum { get; set; }
}
