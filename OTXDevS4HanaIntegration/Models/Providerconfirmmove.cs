using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Providerconfirmmove
{
    public long? Retryid { get; set; }

    public byte? Entrytype { get; set; }

    public DateTime? Queuingdate { get; set; }

    public long? Nodeid { get; set; }

    public long? Versionid { get; set; }

    public string? Versiontype { get; set; }

    public long? Newproviderid { get; set; }

    public string? Extrainfo { get; set; }
}
