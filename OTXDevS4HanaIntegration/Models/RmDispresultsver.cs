using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDispresultsver
{
    public long? Dispnodeid { get; set; }

    public long? Nodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public long? Versionid { get; set; }

    public long? Version { get; set; }

    public long? Majorrel { get; set; }

    public long? Major { get; set; }

    public long? Minor { get; set; }

    public DateTime? Calculateddate { get; set; }

    public string? Rsi { get; set; }

    public long? Classid { get; set; }
}
