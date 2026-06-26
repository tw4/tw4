using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfPulseRawMetadatum
{
    public string IdExtsystem { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string BusinessObjectType { get; set; } = null!;

    public string LsCommentOnObjectId { get; set; } = null!;

    public long? NodeId { get; set; }

    public long? RootNodeId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }
}
