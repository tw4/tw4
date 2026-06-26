using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmsecUsersuppmark
{
    public long? Userid { get; set; }

    public string Suppmark { get; set; } = null!;
}
