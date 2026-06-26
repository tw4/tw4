using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Bestbetsdatum
{
    public long? Dataid { get; set; }

    public string Bestbet { get; set; } = null!;

    public DateTime? Modifydate { get; set; }

    public DateTime? Expiry { get; set; }

    public long? Modifiedby { get; set; }
}
