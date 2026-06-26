using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreesyncextradatum
{
    public long? Dataid { get; set; }

    public string Configkeyword { get; set; } = null!;

    public string? Configvalue { get; set; }
}
