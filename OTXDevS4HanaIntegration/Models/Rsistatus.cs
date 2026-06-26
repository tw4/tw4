using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Rsistatus
{
    public string Rsistatus1 { get; set; } = null!;

    public string? RsistatusDescE { get; set; }

    public string? RsistatusDescF { get; set; }

    public byte? Disabledflag { get; set; }
}
