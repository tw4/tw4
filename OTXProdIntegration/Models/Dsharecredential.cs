using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsharecredential
{
    public long? Userid { get; set; }

    public string Providername { get; set; } = null!;

    public string Provideruserid { get; set; } = null!;

    public string? Accesstoken { get; set; }

    public string? Refreshtoken { get; set; }

    public long? Expirytime { get; set; }

    public string? Tokentype { get; set; }
}
