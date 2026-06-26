using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Labelstock
{
    public string Stockname { get; set; } = null!;

    public string? Stockcomment { get; set; }

    public short? Labelsperpage { get; set; }

    public string? Stockdefxml { get; set; }
}
