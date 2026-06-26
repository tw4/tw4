using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreenotifyrecover
{
    public int? Ntype { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public int? Retries { get; set; }

    public DateTime? Lastretry { get; set; }

    public long? Ownerid { get; set; }

    public long? Subtype { get; set; }
}
