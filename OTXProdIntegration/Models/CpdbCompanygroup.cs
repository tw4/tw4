using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CpdbCompanygroup
{
    public long? Cgid { get; set; }

    public int? Deleted { get; set; }

    public string Name { get; set; } = null!;

    public int? Type { get; set; }

    public int? Cpsection { get; set; }
}
