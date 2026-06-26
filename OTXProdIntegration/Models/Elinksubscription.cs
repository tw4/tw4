using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Elinksubscription
{
    public long? KuafId { get; set; }

    public long? NotifyeventsEventid { get; set; }

    public int? NotifyeventsEventaction { get; set; }

    public long? Objectid { get; set; }

    public int? Objectidtype { get; set; }
}
