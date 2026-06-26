using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmutex
{
    public string Section { get; set; } = null!;

    public DateTime? Timeadded { get; set; }
}
