using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Renditionqueue
{
    public long? Versionseqno { get; set; }

    public DateTime? Queuedate { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Attempt { get; set; }

    public string? Dirused { get; set; }

    public long? Noderuleid { get; set; }
}
