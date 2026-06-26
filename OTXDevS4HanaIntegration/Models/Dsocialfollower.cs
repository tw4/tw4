using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsocialfollower
{
    public long? Nid { get; set; }

    public long? Userid { get; set; }

    public long? Followid { get; set; }

    public DateTime? Followdate { get; set; }
}
