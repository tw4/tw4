using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmCustomization
{
    public string CustomizationType { get; set; } = null!;

    public string? CustomizationValues { get; set; }
}
