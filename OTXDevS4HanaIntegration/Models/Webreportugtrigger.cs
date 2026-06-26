using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Webreportugtrigger
{
    public long? Rowno { get; set; }

    public string Ugevent { get; set; } = null!;

    public long? Wrid { get; set; }

    public long? Userid { get; set; }

    public long? Global { get; set; }

    public long? Inherit { get; set; }
}
