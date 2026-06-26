using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengcadStructuredAttribute
{
    public long? Id { get; set; }

    public string Tag { get; set; } = null!;

    public string? SheetName { get; set; }

    public string? GroupName { get; set; }
}
