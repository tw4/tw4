using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dshareitem
{
    public long? Dataid { get; set; }

    public string Provideritemid { get; set; } = null!;

    public string Providerversionid { get; set; } = null!;

    public long? Sharedversion { get; set; }

    public long? Sharedversionid { get; set; }

    public long? Sharedby { get; set; }

    public short? Sharedownertype { get; set; }

    public DateTime? Sharedon { get; set; }

    public DateTime? Expiredate { get; set; }

    public short? Providertype { get; set; }
}
