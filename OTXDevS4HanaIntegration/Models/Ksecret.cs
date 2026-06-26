using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ksecret
{
    public string Section { get; set; } = null!;

    public string Keyword { get; set; } = null!;

    public string Value { get; set; } = null!;
}
