using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDispositionactionerror
{
    public long? Dispnodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public DateTime? Errordate { get; set; }

    public int? Errorcode { get; set; }

    public long? Dataid { get; set; }

    public string? Name { get; set; }

    public int? Subtype { get; set; }

    public string Action { get; set; } = null!;

    public string? Verfilename { get; set; }

    public long? Classid { get; set; }

    public string? Errorstring { get; set; }
}
