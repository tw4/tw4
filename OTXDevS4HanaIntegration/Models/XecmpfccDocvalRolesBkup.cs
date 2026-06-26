using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfccDocvalRolesBkup
{
    public long? Tdataid { get; set; }

    public long? Cdataid { get; set; }

    public string Location { get; set; } = null!;

    public string? Role { get; set; }
}
