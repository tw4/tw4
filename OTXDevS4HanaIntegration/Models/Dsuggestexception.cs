using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsuggestexception
{
    public string Token { get; set; } = null!;

    public int? Allow { get; set; }
}
