using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Otemaillocationmessageid
{
    public long? Locationnodeid { get; set; }

    public long? Nodeid { get; set; }

    public string Messageid { get; set; } = null!;
}
