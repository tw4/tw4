using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Projectoverviewsetting
{
    public long? Id { get; set; }

    public int? Numtodisplay { get; set; }

    public string Sectionstoshow { get; set; } = null!;
}
