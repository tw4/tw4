using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ddellist
{
    public long? Ownerid { get; set; }

    public string Deletedlist { get; set; } = null!;
}
