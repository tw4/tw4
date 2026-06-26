using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Bravaredactreason
{
    public long? Redactreasonid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Origindataid { get; set; }

    public long? Originversionnum { get; set; }

    public string Reasontext { get; set; } = null!;

    public long? Reasoncount { get; set; }

    public DateTime? Entrydate { get; set; }
}
