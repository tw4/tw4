using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDispsetting
{
    public long? Dispnodeid { get; set; }

    public string Settingkey { get; set; } = null!;

    public string? Settingvalue { get; set; }
}
