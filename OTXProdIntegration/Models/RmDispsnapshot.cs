using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmDispsnapshot
{
    public long? Dispnodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public short? Status { get; set; }

    public long? Cacheid { get; set; }

    public short? Reviewerstep { get; set; }

    public short? Reviewstatus { get; set; }

    public string? Settings { get; set; }

    public int? Recordcount { get; set; }

    public long? Workid { get; set; }
}
