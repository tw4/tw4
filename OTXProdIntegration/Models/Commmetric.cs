using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Commmetric
{
    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public long? Roleid { get; set; }

    public DateTime? Actiondate { get; set; }

    public long? Actiontype { get; set; }

    public string? Extendeddata { get; set; }
}
