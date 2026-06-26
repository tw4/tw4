using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llpolling
{
    public long? Id { get; set; }

    public long? Userid { get; set; }

    public int? Commentnum { get; set; }

    public string? Polldata { get; set; }
}
