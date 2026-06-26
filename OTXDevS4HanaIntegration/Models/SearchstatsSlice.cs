using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class SearchstatsSlice
{
    public decimal? Querynr { get; set; }

    public long? Userid { get; set; }

    public long? Slice { get; set; }
}
