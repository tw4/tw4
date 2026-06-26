using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llcachesecure
{
    public string Cachekey { get; set; } = null!;

    public byte? Deleted { get; set; }

    public long? Userid { get; set; }

    public DateTime? Expiresdate { get; set; }

    public DateTime? Lastupdatedate { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Segmentblob { get; set; }
}
