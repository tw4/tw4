using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wfattrdataversion
{
    public long? WfId { get; set; }

    public long? WfSubworkid { get; set; }

    public int? WfTaskid { get; set; }

    public int? WfAttrid { get; set; }

    public int? WfAttrtype { get; set; }

    public int? WfEntrynum { get; set; }

    public long? WfValint { get; set; }

    public decimal? WfValreal { get; set; }

    public DateTime? WfValdate { get; set; }

    public string? WfValstr { get; set; }

    public string? WfVallong { get; set; }

    public int? WfTaskiternum { get; set; }
}
