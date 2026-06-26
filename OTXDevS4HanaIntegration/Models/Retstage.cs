using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Retstage
{
    public string Retstage1 { get; set; } = null!;

    public string? RetstageDescE { get; set; }

    public string? RetstageDescF { get; set; }

    public short? Retstageorder { get; set; }

    public byte? Disabledflag { get; set; }
}
