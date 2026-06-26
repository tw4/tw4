using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Convertqueue
{
    public long? Dataid { get; set; }

    public long? Parentid { get; set; }

    public DateTime? Queuedate { get; set; }

    public int? Attempt { get; set; }

    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Taskid { get; set; }

    public string Dirused { get; set; } = null!;
}
