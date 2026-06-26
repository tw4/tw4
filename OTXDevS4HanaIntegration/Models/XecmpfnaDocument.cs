using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfnaDocument
{
    public string DocumentId { get; set; } = null!;

    public string DocumentType { get; set; } = null!;

    public string BusinessObjectType { get; set; } = null!;

    public string BusinessObjectId { get; set; } = null!;

    public string ExternalSystemId { get; set; } = null!;

    public long? CsNodeId { get; set; }
}
