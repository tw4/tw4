using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapCbMultiValue
{
    public long? Id { get; set; }

    public long? Ordering { get; set; }

    public string Name { get; set; } = null!;
}
