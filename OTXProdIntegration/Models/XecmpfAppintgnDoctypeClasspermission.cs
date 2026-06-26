using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfAppintgnDoctypeClasspermission
{
    public long? Classpermissionid { get; set; }

    public long? Docclassid { get; set; }

    public string Tasktypeid { get; set; } = null!;

    public string? Tasktypename { get; set; }

    public string Permissiondata { get; set; } = null!;

    public long? Permissionvalue { get; set; }

    public string? Classpermissionuserdata { get; set; }

    public byte? Status { get; set; }

    public long? Version { get; set; }
}
