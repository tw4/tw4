using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wdatum
{
    public long? DataWorkid { get; set; }

    public long? DataSubworkid { get; set; }

    public int? DataType { get; set; }

    public int? DataSubtype { get; set; }

    public string? DataUserdata { get; set; }

    public string? DataDescription { get; set; }
}
