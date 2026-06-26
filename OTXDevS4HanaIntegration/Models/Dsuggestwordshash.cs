using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsuggestwordshash
{
    public long? Id { get; set; }

    public string Hash { get; set; } = null!;

    public int? Penalty { get; set; }
}
