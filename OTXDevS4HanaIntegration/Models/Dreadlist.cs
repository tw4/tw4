using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dreadlist
{
    public long? Userid { get; set; }

    public long? Ownerid { get; set; }

    public string Readlist { get; set; } = null!;
}
