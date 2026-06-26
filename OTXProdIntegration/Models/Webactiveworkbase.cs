using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Webactiveworkbase
{
    public long? WorkWorkid { get; set; }

    public short? WorkStatus { get; set; }

    public long? WorkOwnerid { get; set; }

    public long? WorkManagerid { get; set; }

    public DateTime? WorkDatedueMax { get; set; }

    public int? WorkOwnerperms { get; set; }

    public long? SubworkSubworkid { get; set; }

    public DateTime? SubworkDateinitiated { get; set; }

    public DateTime? SubworkDatedueMax { get; set; }

    public long? MapMapid { get; set; }

    public long? MapMapobjid { get; set; }

    public DateTime? SubworktaskDatemilestone { get; set; }

    public DateTime? SubworktaskDatedueMax { get; set; }
}
