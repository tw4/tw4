using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Area
{
    public string Facility { get; set; } = null!;

    public string Area1 { get; set; } = null!;

    public string? DescE { get; set; }

    public byte? Disabledflag { get; set; }
}
