using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfeacEventdefProperty
{
    public long? PropertyId { get; set; }

    public long? EventDefinitionId { get; set; }

    public string PropertyName { get; set; } = null!;

    public string PropertyDatatype { get; set; } = null!;

    public string? PropertyValuesList { get; set; }

    public string PropertyKey { get; set; } = null!;
}
