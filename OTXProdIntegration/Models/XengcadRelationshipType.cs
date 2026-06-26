using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcadRelationshipType
{
    public long? Id { get; set; }

    public string RelationshipName { get; set; } = null!;

    public byte? RelationshipType { get; set; }
}
