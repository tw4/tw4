using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Recurrence
{
    public string Recurrence1 { get; set; } = null!;

    public string? DescE { get; set; }

    public short? Numberofdays { get; set; }

    public byte? Disabledflag { get; set; }
}
