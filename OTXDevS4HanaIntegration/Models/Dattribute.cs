using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dattribute
{
    public string Attrname { get; set; } = null!;

    public int? Attrtype { get; set; }

    public int? Attrlen { get; set; }

    public string? Dispname { get; set; }

    public string? Disptype { get; set; }

    public string? Defvalue { get; set; }

    public string? Validvals { get; set; }
}
