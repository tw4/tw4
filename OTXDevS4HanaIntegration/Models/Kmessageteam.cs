using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessageteam
{
    public long? Userid { get; set; }

    public long? Msgid { get; set; }

    public int? Deleted { get; set; }

    public short? Attempts { get; set; }

    public int? Deliverystate { get; set; }

    public long? Sourceid { get; set; }

    public int? Messagetype { get; set; }
}
