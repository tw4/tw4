using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kuafidentitytype
{
    public long? Id { get; set; }

    public string Value { get; set; } = null!;

    public string? Display { get; set; }
}
