using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessagecount
{
    public long? Userid { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string Notifysummary { get; set; } = null!;
}
