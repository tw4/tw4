using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Elinkmessagelog
{
    public DateTime? Addedon { get; set; }

    public string? Headers { get; set; }

    public long? Nodeid { get; set; }
}
