using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapAttributeSchema
{
    public long? Catid { get; set; }

    public int? Attrid { get; set; }

    public string Idschema { get; set; } = null!;

    public int? Wksptype { get; set; }

    public long? Maxcounter { get; set; }
}
