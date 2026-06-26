using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wikiredirect
{
    public long? Containerid { get; set; }

    public long? Id { get; set; }

    public string Previousname { get; set; } = null!;
}
