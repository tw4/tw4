using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengtransextuser
{
    public long? Extuserid { get; set; }

    public long? Workspaceid { get; set; }

    public byte? Extusertype { get; set; }

    public string Extusername { get; set; } = null!;

    public string? Extuseremail { get; set; }
}
