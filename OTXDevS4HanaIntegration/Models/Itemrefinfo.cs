using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Itemrefinfo
{
    public long? Seqno { get; set; }

    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Taskid { get; set; }

    public int? Itemrefid { get; set; }

    public int? Itemid { get; set; }

    public int? Lockflag { get; set; }
}
