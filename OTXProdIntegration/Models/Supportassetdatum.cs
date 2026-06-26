using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Supportassetdatum
{
    public long? Agentid { get; set; }

    public long? Dataid { get; set; }

    public long? Parentid { get; set; }

    public int? Subtype { get; set; }

    public DateTime? Deploydate { get; set; }

    public string? Deployurl { get; set; }

    public string? Filepath { get; set; }

    public virtual Supportassetagent Agent { get; set; } = null!;
}
