using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RecdAdminconfig
{
    public string Sectionid { get; set; } = null!;

    public string? Enabled { get; set; }

    public string? Config { get; set; }
}
