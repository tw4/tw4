using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmHrFuncRole
{
    public string SfRoles { get; set; } = null!;

    public long? HrFuncNodeid { get; set; }

    public long? Type { get; set; }
}
