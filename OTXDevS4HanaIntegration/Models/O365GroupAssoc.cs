using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class O365GroupAssoc
{
    public long? Objectid { get; set; }

    public string? O365GroupId { get; set; }

    public string O365ObjectId { get; set; } = null!;

    public string? O365ObjectType { get; set; }

    public string? ExtendedData { get; set; }

    public string? Status { get; set; }
}
