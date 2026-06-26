using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dmultipartcontent
{
    public long? Blockid { get; set; }

    public long? Contentsize { get; set; }

    public DateTime? Arrivaltime { get; set; }

    public string Uploadkey { get; set; } = null!;

    public string Outputfile { get; set; } = null!;
}
