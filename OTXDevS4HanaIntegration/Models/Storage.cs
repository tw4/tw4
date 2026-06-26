using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Storage
{
    public string Storage1 { get; set; } = null!;

    public string? StorageDescE { get; set; }

    public string? StorageDescF { get; set; }

    public byte? Disabledflag { get; set; }
}
