using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llwebsessionlog
{
    public long? Userid { get; set; }

    public byte? Eventtype { get; set; }

    public DateTime? Eventdate { get; set; }
}
