using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Retentionupdateretry
{
    public long? Nodeid { get; set; }

    public long? Versionno { get; set; }

    public string Asarcid { get; set; } = null!;

    public string Asdocid { get; set; } = null!;

    public string Retentionvalue { get; set; } = null!;
}
