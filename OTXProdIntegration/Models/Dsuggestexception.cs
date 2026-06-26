using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsuggestexception
{
    public string Token { get; set; } = null!;

    public int? Allow { get; set; }
}
