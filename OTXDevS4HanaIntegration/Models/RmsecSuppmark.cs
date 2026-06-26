using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmsecSuppmark
{
    public string Suppmark { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? Bitmask { get; set; }

    public byte? Disabledflag { get; set; }
}
