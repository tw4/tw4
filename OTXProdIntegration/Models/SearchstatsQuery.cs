using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class SearchstatsQuery
{
    public long? Querynr { get; set; }

    public long? Userid { get; set; }

    public DateTime? Querytime { get; set; }

    public int? Searchtype { get; set; }

    public long? Template { get; set; }

    public long? Rawresults { get; set; }

    public long? Queryhash { get; set; }

    public long? Queryhashgeneral { get; set; }

    public long? Maxdisplayed { get; set; }

    public decimal? Querytimeinms { get; set; }

    public long? Queryhashnofacet { get; set; }

    public long? Hopcount { get; set; }
}
