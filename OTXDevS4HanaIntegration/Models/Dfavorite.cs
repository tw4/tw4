using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dfavorite
{
    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public long? Tabid { get; set; }

    public string Name { get; set; } = null!;

    public long? Ordering { get; set; }
}
