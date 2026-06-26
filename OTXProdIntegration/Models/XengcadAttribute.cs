using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcadAttribute
{
    public long? Id { get; set; }

    public long? Nodeid { get; set; }

    public string Name { get; set; } = null!;

    public byte? Type { get; set; }

    public long? Setid { get; set; }

    public long? Orderprev { get; set; }
}
