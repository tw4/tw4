using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wsubwork
{
    public long? SubworkWorkid { get; set; }

    public long? SubworkSubworkid { get; set; }

    public long? SubworkMapid { get; set; }

    public int? SubworkFlags { get; set; }

    public long? SubworkReturnsubworkid { get; set; }

    public int? SubworkReturntaskid { get; set; }

    public DateTime? SubworkDatedueMin { get; set; }

    public DateTime? SubworkDatedueMax { get; set; }

    public DateTime? SubworkDateinitiated { get; set; }

    public DateTime? SubworkDatecompleted { get; set; }

    public short? SubworkStatus { get; set; }

    public string? SubworkTitle { get; set; }

    public string? SubworkProject { get; set; }

    public string? SubworkUserdata { get; set; }

    public string? SubworkCustomdata { get; set; }
}
