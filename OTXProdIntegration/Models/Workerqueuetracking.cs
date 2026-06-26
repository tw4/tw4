using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Workerqueuetracking
{
    public int? Checktime { get; set; }

    public string Handlerid { get; set; } = null!;

    public byte? Eventtype { get; set; }

    public int? Count { get; set; }
}
