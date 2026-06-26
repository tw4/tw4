using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Disposition
{
    public string Disposition1 { get; set; } = null!;

    public string? DispositionDescE { get; set; }

    public string? DispositionDescF { get; set; }

    public byte? Disabledflag { get; set; }
}
