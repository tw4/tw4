using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CwscoreshareInstancemapping
{
    public long? Instanceid { get; set; }

    public long? Dataid { get; set; }

    public long? Mapid { get; set; }

    public string Shareditems { get; set; } = null!;

    public long? Mapversion { get; set; }

    public byte? Processstatus { get; set; }

    public string? Processmessage { get; set; }
}
