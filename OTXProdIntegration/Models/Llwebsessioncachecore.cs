using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llwebsessioncachecore
{
    public string Sessionid { get; set; } = null!;

    public long? Userid { get; set; }

    public long? Deleted { get; set; }

    public string? Remoteaddr { get; set; }

    public string? Useragent { get; set; }

    public DateTime? Lastupdatedate { get; set; }

    public DateTime? Expiresdate { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Segmentblob { get; set; }
}
