using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class EcmlinkWkspUnion
{
    public long? Dataid { get; set; }

    public string WkspTypeName { get; set; } = null!;

    public int? IdWkspType { get; set; }

    public int? WkspTypeDeleted { get; set; }

    public string? BusinessObjectType { get; set; }

    public int? BoTypeDeleted { get; set; }

    public string? IdExtsystem { get; set; }

    public int? IsDefaultDisplay { get; set; }

    public int? IdBoType { get; set; }

    public string? IdBo { get; set; }
}
