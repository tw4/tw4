using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmHoldquery
{
    public long? Holdid { get; set; }

    public long? Queryid { get; set; }

    public byte? Enabled { get; set; }

    public short? Runstatus { get; set; }
}
