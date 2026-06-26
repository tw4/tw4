using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Logininfo
{
    public long? Userid { get; set; }

    public string Username { get; set; } = null!;

    public int? Numfailed { get; set; }

    public string? Spassword { get; set; }

    public DateTime? Expiredate { get; set; }
}
