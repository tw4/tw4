using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapReferenceType
{
    public int? Deleted { get; set; }

    public int? IdReferenceType { get; set; }

    public string Name { get; set; } = null!;

    public int? WkspPolEnabled { get; set; }

    public string? WkspIcon { get; set; }

    public int? IndexingEnabled { get; set; }

    public int? UseLocationManual { get; set; }

    public int? GenerateNameEarly { get; set; }

    public long? ConfigNodeId { get; set; }

    public int? RmEnabled { get; set; }

    public int? UseBulkapi { get; set; }

    public int? CopyDisabled { get; set; }

    public int? AviatorEnabled { get; set; }
}
