using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Workerpackage
{
    public long? Taskid { get; set; }

    public string Blob { get; set; } = null!;
}
