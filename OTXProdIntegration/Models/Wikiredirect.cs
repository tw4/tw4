using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wikiredirect
{
    public long? Containerid { get; set; }

    public long? Id { get; set; }

    public string Previousname { get; set; } = null!;
}
