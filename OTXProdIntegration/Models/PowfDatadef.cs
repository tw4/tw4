using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class PowfDatadef
{
    public long? Mapid { get; set; }

    public long? Taskid { get; set; }

    public string Name { get; set; } = null!;

    public long? Partype { get; set; }

    public long? Chitype { get; set; }

    public byte[] Guid { get; set; } = null!;
}
