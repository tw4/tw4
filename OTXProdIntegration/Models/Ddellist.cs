using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ddellist
{
    public long? Ownerid { get; set; }

    public string Deletedlist { get; set; } = null!;
}
