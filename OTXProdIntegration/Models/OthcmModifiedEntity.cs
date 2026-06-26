using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmModifiedEntity
{
    public string EntityId { get; set; } = null!;

    public long? EntityType { get; set; }

    public DateTime? ModifyDate { get; set; }
}
