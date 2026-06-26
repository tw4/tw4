using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kuafidentity
{
    public long? Id { get; set; }

    public long? Typeid { get; set; }

    public string Value { get; set; } = null!;

    public string? Display { get; set; }

    public long? Userid { get; set; }
}
