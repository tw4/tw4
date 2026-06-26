using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CpdbStateprovince
{
    public long? Spid { get; set; }

    public int? Deleted { get; set; }

    public string Stateprovince { get; set; } = null!;

    public string? Fipscode { get; set; }

    public long? Coid { get; set; }
}
