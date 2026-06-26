using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Providerdatum
{
    public long? Providerid { get; set; }

    public int? Refcnt { get; set; }

    public string Providertype { get; set; } = null!;

    public string Providerdata { get; set; } = null!;
}
