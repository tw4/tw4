using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsignature
{
    public long? Vers { get; set; }

    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Dataid { get; set; }

    public int? Signtype { get; set; }
}
