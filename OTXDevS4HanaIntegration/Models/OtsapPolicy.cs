using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapPolicy
{
    public long? Dataid { get; set; }

    public int? IdBoType { get; set; }

    public string? Profile { get; set; }

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
