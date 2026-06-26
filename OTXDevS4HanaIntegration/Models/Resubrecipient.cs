using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Resubrecipient
{
    public long? Rsid { get; set; }

    public long? Userid { get; set; }

    public long? Notification { get; set; }

    public int? Notified { get; set; }

    public int? Reciptype { get; set; }
}
