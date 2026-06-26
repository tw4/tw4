using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Renditionmimetyperule
{
    public long? Mimetyperuleid { get; set; }

    public string Mimetyperulename { get; set; } = null!;

    public long? Globalrendition { get; set; }

    public string? Settings { get; set; }
}
