using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Bravathumb
{
    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Thumbsize { get; set; }

    public DateTime? Reqtime { get; set; }

    public long? Status { get; set; }

    public long? Complete { get; set; }

    public long? Numtries { get; set; }

    public string? Errmsg { get; set; }
}
