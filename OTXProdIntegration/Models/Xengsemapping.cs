using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Xengsemapping
{
    public long? Mappingid { get; set; }

    public long? Dataid { get; set; }

    public byte? Status { get; set; }

    public long? Workspacetemplate { get; set; }

    public string Contract { get; set; } = null!;
}
