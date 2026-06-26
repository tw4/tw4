using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Licaccess
{
    public long? Memberid { get; set; }

    public int? Accessdate { get; set; }

    public int? Audittype { get; set; }

    public long? Audititem { get; set; }
}
