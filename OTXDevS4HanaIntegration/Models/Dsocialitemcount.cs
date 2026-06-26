using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsocialitemcount
{
    public long? Userid { get; set; }

    public int? Mentions { get; set; }

    public int? Privatemessages { get; set; }

    public int? Following { get; set; }

    public int? Followers { get; set; }
}
