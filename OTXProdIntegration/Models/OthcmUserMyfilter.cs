using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmUserMyfilter
{
    public string SfUserId { get; set; } = null!;

    public string MyFilter { get; set; } = null!;

    public string? Value { get; set; }
}
