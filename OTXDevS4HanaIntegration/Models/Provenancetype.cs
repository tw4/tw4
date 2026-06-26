using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Provenancetype
{
    public string Provenancetype1 { get; set; } = null!;

    public string? ProvenancetypeDescE { get; set; }

    public string? ProvenancetypeDescAdd { get; set; }

    public byte? Disabledflag { get; set; }
}
