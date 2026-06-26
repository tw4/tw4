using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Projectoverviewsetting
{
    public long? Id { get; set; }

    public int? Numtodisplay { get; set; }

    public string Sectionstoshow { get; set; } = null!;
}
