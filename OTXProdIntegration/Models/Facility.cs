using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Facility
{
    public string Facility1 { get; set; } = null!;

    public string? DescE { get; set; }

    public byte? Managed { get; set; }

    public int? Checkboxfit { get; set; }

    public string? Address { get; set; }

    public byte? Disabledflag { get; set; }
}
