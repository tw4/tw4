using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Labeldefinition
{
    public string Labeldefname { get; set; } = null!;

    public string? Stockname { get; set; }

    public string? Labelcomment { get; set; }

    public string? Labeldefxml { get; set; }

    public byte? Labeltype { get; set; }
}
