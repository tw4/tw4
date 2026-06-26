using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CmbaseUpgradelog
{
    public long? Id { get; set; }

    public string Action { get; set; } = null!;

    public int? Status { get; set; }

    public string? Logmsg { get; set; }
}
