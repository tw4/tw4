using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Workerpackage
{
    public long? Taskid { get; set; }

    public string Blob { get; set; } = null!;
}
