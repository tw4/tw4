using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmCustomizationsExtn
{
    public string CustomizationType { get; set; } = null!;

    public string? CustomizationValues { get; set; }
}
