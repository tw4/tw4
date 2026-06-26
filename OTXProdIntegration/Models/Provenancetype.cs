using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Provenancetype
{
    public string Provenancetype1 { get; set; } = null!;

    public string? ProvenancetypeDescE { get; set; }

    public string? ProvenancetypeDescAdd { get; set; }

    public byte? Disabledflag { get; set; }
}
