using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Indextracerdatum
{
    public long? Tracerid { get; set; }

    public long? Seq { get; set; }

    public short? Operation { get; set; }

    public string Iterator { get; set; } = null!;

    public long? Extractorid { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Extracttime { get; set; }

    public string Dcsid { get; set; } = null!;

    public DateTime? Dcsconversiontime { get; set; }

    public DateTime? Indextime { get; set; }
}
