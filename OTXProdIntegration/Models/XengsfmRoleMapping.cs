using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengsfmRoleMapping
{
    public long? Id { get; set; }

    public long? RolemapId { get; set; }

    public long? DocumentTypeId { get; set; }

    public long? WorkspaceRoleId { get; set; }
}
