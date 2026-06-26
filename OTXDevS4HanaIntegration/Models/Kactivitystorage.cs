using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kactivitystorage
{
    public long? Rownumid { get; set; }

    public long? Eventdatenum { get; set; }

    public string? Profilekey { get; set; }

    public string? Provider { get; set; }

    public string? Operation { get; set; }

    public long? Filesize { get; set; }

    public long? Maxtime { get; set; }

    public long? Mintime { get; set; }

    public long? Totaltime { get; set; }

    public long? Totalcount { get; set; }

    public string? Reference { get; set; }
}
