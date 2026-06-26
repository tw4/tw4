using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Bestbetssearch
{
    public long? Dataid { get; set; }

    public string Bestbetsearch { get; set; } = null!;

    public byte? Expired { get; set; }
}
