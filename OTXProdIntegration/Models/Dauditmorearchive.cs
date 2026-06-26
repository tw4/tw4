using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dauditmorearchive
{
    public long? Eventid { get; set; }

    public string Keystr { get; set; } = null!;

    public string? Valuestr { get; set; }
}
