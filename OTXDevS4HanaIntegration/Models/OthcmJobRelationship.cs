using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmJobRelationship
{
    public string SfUserId { get; set; } = null!;

    public string? RelationRole { get; set; }

    public string? SfMgrUserId { get; set; }
}
