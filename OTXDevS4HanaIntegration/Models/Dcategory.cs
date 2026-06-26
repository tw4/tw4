using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dcategory
{
    public string Catname { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public string? Dispname { get; set; }
}
