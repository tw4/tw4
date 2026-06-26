using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ugenerator
{
    public string Uniqueval { get; set; } = null!;

    public string Doctype { get; set; } = null!;

    public string Docprefix { get; set; } = null!;

    public string Appltype { get; set; } = null!;

    public int? Mainpart { get; set; }

    public int? Secondpart { get; set; }
}
