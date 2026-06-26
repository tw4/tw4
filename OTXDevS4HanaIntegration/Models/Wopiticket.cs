using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wopiticket
{
    public string Ticket { get; set; } = null!;

    public string Rdm { get; set; } = null!;

    public long? Userid { get; set; }

    public long? Nodeid { get; set; }

    public DateTime? Exp { get; set; }

    public string? Extendeddata { get; set; }
}
