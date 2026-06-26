using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Webreport
{
    public long? Nodeid { get; set; }

    public long? Userid { get; set; }

    public long? Seqno { get; set; }

    public long? Schedenabled { get; set; }

    public DateTime? Nextrun { get; set; }

    public long? Runtimes { get; set; }

    public long? Repmin { get; set; }

    public long? Rephour { get; set; }

    public long? Repday { get; set; }

    public long? Repweek { get; set; }

    public string? Wrdata { get; set; }

    public string? Runcondition { get; set; }

    public string? Rundates { get; set; }

    public string? Runweeks { get; set; }

    public string? Rundaysmonth { get; set; }

    public string? Rundaysweek { get; set; }
}
