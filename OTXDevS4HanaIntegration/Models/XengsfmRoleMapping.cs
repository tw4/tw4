using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengsfmRoleMapping
{
    public long? Id { get; set; }

    public long? RolemapId { get; set; }

    public long? DocumentTypeId { get; set; }

    public long? WorkspaceRoleId { get; set; }
}
