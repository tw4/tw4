using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreesyncmessage
{
    public long? Messageid { get; set; }

    public long? Type { get; set; }

    public string Info { get; set; } = null!;

    public DateTime? TimeStamp { get; set; }

    public long? Flags { get; set; }
}
