using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Webreporttrigger
{
    public long? Dataid { get; set; }

    public long? Wrid { get; set; }

    public long? Inherit { get; set; }

    public string? Triggers { get; set; }

    public long? Show { get; set; }
}
