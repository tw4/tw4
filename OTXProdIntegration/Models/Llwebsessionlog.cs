using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llwebsessionlog
{
    public long? Userid { get; set; }

    public byte? Eventtype { get; set; }

    public DateTime? Eventdate { get; set; }
}
