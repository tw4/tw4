using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Notifyinterests2
{
    public long? Userid { get; set; }

    public long? Nodeid { get; set; }

    public byte? Interestlevel { get; set; }

    public long? Eventidmask { get; set; }
}
