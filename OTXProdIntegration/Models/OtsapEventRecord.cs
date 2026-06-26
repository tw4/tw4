using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapEventRecord
{
    public long? Dataid { get; set; }

    public long? Ownerid { get; set; }

    public string Subscriber { get; set; } = null!;

    public DateTime? EventDate { get; set; }

    public int? EventType { get; set; }
}
