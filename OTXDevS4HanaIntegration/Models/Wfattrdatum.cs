using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wfattrdatum
{
    public long? WfId { get; set; }

    public int? WfAttrid { get; set; }

    public int? WfAttrtype { get; set; }

    public int? WfEntrynum { get; set; }

    public long? WfValint { get; set; }

    public decimal? WfValreal { get; set; }

    public DateTime? WfValdate { get; set; }

    public string? WfValstr { get; set; }

    public string? WfVallong { get; set; }
}
