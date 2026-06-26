using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class SearchstatsTerm
{
    public decimal? Querynr { get; set; }

    public long? Userid { get; set; }

    public string Term { get; set; } = null!;

    public string Termlower { get; set; } = null!;
}
