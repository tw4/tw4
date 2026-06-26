using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Otdocumenthold
{
    public long? Holdid { get; set; }

    public string Otitemid { get; set; } = null!;

    public string Otvolumeid { get; set; } = null!;

    public long? Activehold { get; set; }
}
