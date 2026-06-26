using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcadRelation
{
    public long? Id { get; set; }

    public long? Sourcedataid { get; set; }

    public long? Sourcedocversion { get; set; }

    public long? Relateddataid { get; set; }

    public long? Relateddocversion { get; set; }

    public long? RelationshipId { get; set; }
}
