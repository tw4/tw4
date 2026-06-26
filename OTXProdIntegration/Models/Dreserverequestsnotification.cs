using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dreserverequestsnotification
{
    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public DateTime? Notifydate { get; set; }

    public long? Attempt { get; set; }
}
