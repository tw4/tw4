using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsuggestword
{
    public long? Nid { get; set; }

    public short? Type { get; set; }

    public string Namespace { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long? Occcount { get; set; }
}
