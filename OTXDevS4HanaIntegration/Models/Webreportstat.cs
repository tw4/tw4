using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Webreportstat
{
    public long? Userid { get; set; }

    public long? Userstatus { get; set; }

    public DateTime? Datefirstaction { get; set; }

    public DateTime? Datelastaction { get; set; }

    public string? Action { get; set; }

    public long? Nodeid { get; set; }

    public string? Stats { get; set; }
}
