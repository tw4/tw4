using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class SearchstatsStopcondition
{
    public long? Querynr { get; set; }

    public long? Queryhashnofacet { get; set; }

    public DateTime? Stoptime { get; set; }

    public int? Hitindex { get; set; }

    public string Operation { get; set; } = null!;
}
