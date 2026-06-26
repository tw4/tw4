using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llcommnotification
{
    public long? Userid { get; set; }

    public long? Cid { get; set; }

    public string Subtypes { get; set; } = null!;
}
