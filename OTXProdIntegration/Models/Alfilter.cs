using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Alfilter
{
    public string Hostname { get; set; } = null!;

    public long? Port { get; set; }
}
