using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmCustomization
{
    public string CustomizationType { get; set; } = null!;

    public string? CustomizationValues { get; set; }
}
