using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Workerstatus
{
    public string Workerid { get; set; } = null!;

    public byte? Agenttype { get; set; }

    public DateTime? Lastupdate { get; set; }

    public int? Laststatus { get; set; }

    public string? Statusstr { get; set; }

    public int? Counter { get; set; }
}
