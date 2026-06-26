using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Supportassetorder
{
    public long? Orderid { get; set; }

    public long? Agentid { get; set; }

    public long? Dataid { get; set; }

    public int? Subtype { get; set; }

    public DateTime? Createdate { get; set; }

    public int? Ordertype { get; set; }

    public int? Retrycount { get; set; }

    public virtual Supportassetagent Agent { get; set; } = null!;
}
