using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmsecStat
{
    public int? Type { get; set; }

    public long? Dataid { get; set; }

    public long? Usergroupid { get; set; }

    public string Serverthread { get; set; } = null!;

    public string Valuekey { get; set; } = null!;

    public string? Valuekey1 { get; set; }

    public int? Recordcount { get; set; }

    public DateTime? Rundate { get; set; }
}
