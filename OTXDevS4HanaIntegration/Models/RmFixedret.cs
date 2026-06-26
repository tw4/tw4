using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmFixedret
{
    public long? Nodeid { get; set; }

    public DateTime? Initialret { get; set; }

    public DateTime? Currentret { get; set; }

    public short? Infinite { get; set; }
}
