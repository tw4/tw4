using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dmetadatastate
{
    public string Keystr { get; set; } = null!;

    public string Tokenstr { get; set; } = null!;

    public DateTime? Modifydate { get; set; }
}
