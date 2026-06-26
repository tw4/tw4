using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfPulseMetadatum
{
    public string IdExtsystem { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    public long? NodeId { get; set; }

    public long? RootNodeId { get; set; }

    public string BusinessObjectType { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }
}
