using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kmessageemail
{
    public long? Userid { get; set; }

    public long? Msgid { get; set; }

    public int? Deleted { get; set; }

    public DateTime? Deliverafter { get; set; }

    public short? Attempts { get; set; }

    public int? State { get; set; }

    public long? Sourceid { get; set; }

    public int? Messagetype { get; set; }
}
