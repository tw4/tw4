using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Physitemext
{
    public long? Nodeid { get; set; }

    public string Fieldname { get; set; } = null!;

    public string? Fieldvalue { get; set; }
}
