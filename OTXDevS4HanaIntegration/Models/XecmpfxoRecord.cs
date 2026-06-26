using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfxoRecord
{
    public long? Dataid { get; set; }

    public string Applicationid { get; set; } = null!;

    public string Externalid { get; set; } = null!;

    public string? Busobjtype { get; set; }

    public string? Busobjid { get; set; }
}
