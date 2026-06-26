using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualscanhost
{
    public long? Scanhostid { get; set; }

    public string Scanhostname { get; set; } = null!;

    public string? Scanhostsite { get; set; }

    public string? Scanhostdesc { get; set; }

    public DateTime? Lasttouchdate { get; set; }
}
