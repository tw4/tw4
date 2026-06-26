using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmHrFuncRole
{
    public string SfRoles { get; set; } = null!;

    public long? HrFuncNodeid { get; set; }

    public long? Type { get; set; }
}
