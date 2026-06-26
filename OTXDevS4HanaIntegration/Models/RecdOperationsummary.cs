using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RecdOperationsummary
{
    public DateTime? Firstaccess { get; set; }

    public DateTime? Recentaccess { get; set; }

    public decimal? Meandate { get; set; }

    public decimal? Meansqdate { get; set; }

    public decimal? Meantime { get; set; }

    public decimal? Meansqtime { get; set; }

    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public long? Objtype { get; set; }

    public string Action { get; set; } = null!;

    public long? Refcount { get; set; }

    public long? Subtype { get; set; }
}
