using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapBoTypesDocType
{
    public int? IdBoType { get; set; }

    public long? IdDeclarationType { get; set; }

    public int? IsBusinessAttachment { get; set; }

    public string DocType { get; set; } = null!;
}
