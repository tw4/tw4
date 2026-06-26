using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Supportassetagent
{
    public long? Agentid { get; set; }

    public string Name { get; set; } = null!;

    public string Deploydirectory { get; set; } = null!;

    public string Status { get; set; } = null!;
}
