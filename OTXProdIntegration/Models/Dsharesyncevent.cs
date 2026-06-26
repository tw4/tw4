using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsharesyncevent
{
    public long? Eventid { get; set; }

    public DateTime? Eventtime { get; set; }

    public short? Eventtype { get; set; }

    public string? Eventuserid { get; set; }

    public string? Eventparam { get; set; }

    public short? Providertype { get; set; }

    public string? Provideritemid { get; set; }

    public string? Providerversionid { get; set; }

    public string Synctaskid { get; set; } = null!;
}
