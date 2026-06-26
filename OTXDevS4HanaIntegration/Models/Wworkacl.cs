using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wworkacl
{
    public long? WorkaclWorkid { get; set; }

    public long? WorkaclRightid { get; set; }

    public int? WorkaclPermissions { get; set; }
}
