using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Holdtype
{
    public string Holdtype1 { get; set; } = null!;

    public string? HoldtypeDescE { get; set; }

    public string? HoldtypeDescF { get; set; }

    public short? Defaultperiod { get; set; }

    public byte? Disabledflag { get; set; }
}
