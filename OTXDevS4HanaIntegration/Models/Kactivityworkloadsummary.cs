using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kactivityworkloadsummary
{
    public long? Rowidnum { get; set; }

    public long? Timestamp { get; set; }

    public string? Profilekey { get; set; }

    public string? Classname { get; set; }

    public string? Operation { get; set; }

    public long? Maxtime { get; set; }

    public long? Mintime { get; set; }

    public long? Totaltime { get; set; }

    public long? Totalcount { get; set; }

    public string? Reference { get; set; }
}
