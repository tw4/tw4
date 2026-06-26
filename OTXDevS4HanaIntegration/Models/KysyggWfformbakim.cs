using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysyggWfformbakim
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public string? Wfform { get; set; }

    public int? Aktif { get; set; }
}
