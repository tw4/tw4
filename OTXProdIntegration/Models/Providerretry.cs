using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Providerretry
{
    public long? Retryid { get; set; }

    public byte? Entrytype { get; set; }

    public DateTime? Queuingdate { get; set; }

    public string Providername { get; set; } = null!;

    public string Providerdata { get; set; } = null!;

    public short? Errortype { get; set; }

    public string? Deleteerror { get; set; }

    public DateTime? Retentionexpirydate { get; set; }

    public string? Extrainfo { get; set; }

    public string Hashstr { get; set; } = null!;
}
