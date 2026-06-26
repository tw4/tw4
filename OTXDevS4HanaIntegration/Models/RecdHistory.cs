using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RecdHistory
{
    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public DateTime? Eventdate { get; set; }

    public short? Class { get; set; }

    public long? Subtype { get; set; }
}
