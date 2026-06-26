using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class EcmlinkWkspLinked
{
    public long? Dataid { get; set; }

    public int? IdBoType { get; set; }

    public string IdBo { get; set; } = null!;

    public string BusinessObjectType { get; set; } = null!;

    public string BoTypeName { get; set; } = null!;

    public int? BoTypeDeleted { get; set; }

    public string IdExtsystem { get; set; } = null!;

    public int? IsDefaultDisplay { get; set; }

    public int? IsDefaultSearch { get; set; }

    public int? IdReferenceType { get; set; }

    public string WkspTypeName { get; set; } = null!;

    public int? WkspTypeDeleted { get; set; }
}
