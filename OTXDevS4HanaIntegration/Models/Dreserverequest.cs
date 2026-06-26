using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dreserverequest
{
    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public DateTime? Reservedate { get; set; }

    public long? Ordering { get; set; }
}
