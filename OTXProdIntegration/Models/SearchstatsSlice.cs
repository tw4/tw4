using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class SearchstatsSlice
{
    public decimal? Querynr { get; set; }

    public long? Userid { get; set; }

    public long? Slice { get; set; }
}
