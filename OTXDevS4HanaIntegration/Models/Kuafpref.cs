using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kuafpref
{
    public long? Prefsid { get; set; }

    public string Prefskeyword { get; set; } = null!;

    public string Prefsvalue { get; set; } = null!;
}
