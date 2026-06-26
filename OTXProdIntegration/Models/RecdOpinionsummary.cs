using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RecdOpinionsummary
{
    public long? Dataid { get; set; }

    public decimal? Ratingsum { get; set; }

    public long? Ratingnum { get; set; }

    public decimal? Ratingavg { get; set; }

    public DateTime? Opiniondatemax { get; set; }
}
