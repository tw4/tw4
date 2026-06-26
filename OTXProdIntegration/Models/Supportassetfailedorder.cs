using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Supportassetfailedorder
{
    public long? Orderid { get; set; }

    public long? Agentid { get; set; }

    public long? Dataid { get; set; }

    public int? Subtype { get; set; }

    public DateTime? Createdate { get; set; }

    public int? Ordertype { get; set; }

    public DateTime? Errordate { get; set; }

    public string? Errormessage { get; set; }

    public virtual Supportassetagent Agent { get; set; } = null!;
}
