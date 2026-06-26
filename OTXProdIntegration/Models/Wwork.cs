using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wwork
{
    public long? WorkWorkid { get; set; }

    public int? WorkFlags { get; set; }

    public DateTime? WorkDatedueMin { get; set; }

    public DateTime? WorkDatedueMax { get; set; }

    public DateTime? WorkDateinitiated { get; set; }

    public DateTime? WorkDatecompleted { get; set; }

    public long? WorkOwnerid { get; set; }

    public long? WorkManagerid { get; set; }

    public short? WorkStatus { get; set; }

    public string? WorkProject { get; set; }

    public string? WorkUserdata { get; set; }

    public string? WorkCustomdata { get; set; }

    public int? WorkOwnerperms { get; set; }
}
