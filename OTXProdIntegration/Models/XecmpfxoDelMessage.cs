using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfxoDelMessage
{
    public long? Messageid { get; set; }

    public DateTime? Messagedate { get; set; }

    public string Applicationid { get; set; } = null!;

    public long? Nodeid { get; set; }

    public string Archiveid { get; set; } = null!;

    public string Docid { get; set; } = null!;

    public string? Busobjtype { get; set; }

    public string? Busobjid { get; set; }
}
