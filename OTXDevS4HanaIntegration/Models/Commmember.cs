using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Commmember
{
    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Memberdate { get; set; }

    public long? Userroleid { get; set; }

    public string? Userstatus { get; set; }

    public DateTime? Lastondate { get; set; }

    public string Extendeddata { get; set; } = null!;
}
