using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kuafuserproxy
{
    public long? Proxyid { get; set; }

    public long? Targetid { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }
}
