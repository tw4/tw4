using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsocialobjectsdisposition
{
    public DateTime? Dispodate { get; set; }

    public string Action { get; set; } = null!;

    public long? Dataid { get; set; }

    public string Appid { get; set; } = null!;

    public string? Remoteid { get; set; }
}
