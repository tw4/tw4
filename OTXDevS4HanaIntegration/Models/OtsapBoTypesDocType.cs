using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapBoTypesDocType
{
    public int? IdBoType { get; set; }

    public long? IdDeclarationType { get; set; }

    public int? IsBusinessAttachment { get; set; }

    public string DocType { get; set; } = null!;
}
