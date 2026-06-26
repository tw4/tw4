using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmsecSecurity
{
    public int? Securitylevel { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public byte? Disabledflag { get; set; }
}
