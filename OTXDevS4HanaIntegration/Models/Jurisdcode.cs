using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Jurisdcode
{
    public string Jurisdcode1 { get; set; } = null!;

    public string? JurisdcodeDescE { get; set; }

    public byte? Disabledflag { get; set; }
}
