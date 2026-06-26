using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kuafusagesummary
{
    public long? Id { get; set; }

    public int? Operationcount { get; set; }

    public int? Accesscount { get; set; }

    public int? Writecount { get; set; }

    public int? Nonreadcount { get; set; }

    public int? Datestamp { get; set; }
}
