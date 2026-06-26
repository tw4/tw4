using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmUserhold
{
    public long? Userid { get; set; }

    public long? Holdid { get; set; }

    public short? Status { get; set; }
}
