using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dfavoritestab
{
    public long? Tabid { get; set; }

    public long? Userid { get; set; }

    public string Name { get; set; } = null!;

    public long? Ordering { get; set; }
}
