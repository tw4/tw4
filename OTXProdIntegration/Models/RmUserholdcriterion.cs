using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmUserholdcriterion
{
    public long? Holdid { get; set; }

    public short? Status { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Comments { get; set; }
}
