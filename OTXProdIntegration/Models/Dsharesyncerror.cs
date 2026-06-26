using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsharesyncerror
{
    public long? Csitemid { get; set; }

    public short? Providertype { get; set; }

    public string? Provideritemid { get; set; }

    public DateTime? Errortime { get; set; }

    public short? Erroroperation { get; set; }

    public short? Errorstatus { get; set; }

    public string? Errordiagnostics { get; set; }
}
