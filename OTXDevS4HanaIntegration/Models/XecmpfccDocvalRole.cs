using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfccDocvalRole
{
    public long? Tdataid { get; set; }

    public long? Cdataid { get; set; }

    public string? Location { get; set; }

    public string? Role { get; set; }

    public string RoleType { get; set; } = null!;

    public long? Ruleid { get; set; }

    public long? Roleid { get; set; }

    public string? Reviewwfmaprole { get; set; }
}
