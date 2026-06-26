using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessageparam
{
    public string Paramkey { get; set; } = null!;

    public long? Bodyid { get; set; }

    public string Command { get; set; } = null!;

    public string Params { get; set; } = null!;
}
