using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapUniqueName
{
    public long? Dataid { get; set; }

    public string UniqueName { get; set; } = null!;

    public long? UniqueNameNodeId { get; set; }
}
