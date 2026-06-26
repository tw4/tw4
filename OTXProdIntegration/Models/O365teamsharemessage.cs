using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class O365teamsharemessage
{
    public string Messagekey { get; set; } = null!;

    public DateTime? Inserteddate { get; set; }

    public short? Failurecount { get; set; }

    public string? Messagetext { get; set; }
}
