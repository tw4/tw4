using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualarchivemode
{
    public long? Archivemodeid { get; set; }

    public string Scenarioname { get; set; } = null!;

    public string Archivemodename { get; set; } = null!;

    public long? Archivedataid { get; set; }

    public long? Sapsystemid { get; set; }

    public short? Dpport { get; set; }

    public string? Dpprotocol { get; set; }

    public string? Dphost { get; set; }

    public DateTime? Lasttouchdate { get; set; }

    public string? Conditionjson { get; set; }
}
