using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Spcschedule
{
    public long? Dataid { get; set; }

    public string SpcDay { get; set; } = null!;

    public long? SpcTime { get; set; }

    public long? SpcDuration { get; set; }
}
