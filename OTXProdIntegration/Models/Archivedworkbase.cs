using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Archivedworkbase
{
    public long? WorkWorkid { get; set; }

    public short? WorkStatus { get; set; }

    public long? WorkOwnerid { get; set; }

    public long? WorkManagerid { get; set; }

    public DateTime? WorkDatedueMax { get; set; }

    public int? WorkOwnerperms { get; set; }

    public long? SubworkSubworkid { get; set; }

    public DateTime? SubworkDateinitiated { get; set; }

    public string? SubworkTitle { get; set; }

    public short? SubworkStatus { get; set; }

    public long? SubworkReturnsubworkid { get; set; }

    public string? SubworkUserdata { get; set; }

    public long? MapMapid { get; set; }

    public long? MapMapobjid { get; set; }
}
