using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RecdOperationtracking
{
    public long? Operationiden { get; set; }

    public DateTime? Operationdate { get; set; }

    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public long? Objtype { get; set; }

    public string Action { get; set; } = null!;

    public string? Fromlocation { get; set; }

    public string? Pathinfo { get; set; }
}
