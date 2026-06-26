using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Physitemext
{
    public long? Nodeid { get; set; }

    public string Fieldname { get; set; } = null!;

    public string? Fieldvalue { get; set; }
}
