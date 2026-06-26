using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Timeoutgroup
{
    public long? Id { get; set; }

    public int? Type { get; set; }

    public int? Timeout { get; set; }
}
