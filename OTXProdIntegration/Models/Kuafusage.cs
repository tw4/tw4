using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kuafusage
{
    public long? Id { get; set; }

    public string Profilekey { get; set; } = null!;

    public int? Operationcount { get; set; }

    public int? Accesscount { get; set; }

    public int? Writecount { get; set; }

    public int? Nonreadcount { get; set; }

    public int? Datestamp { get; set; }
}
