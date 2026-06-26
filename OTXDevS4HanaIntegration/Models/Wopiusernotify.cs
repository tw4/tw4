using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wopiusernotify
{
    public long? Userid { get; set; }

    public DateTime? Promotedate { get; set; }

    public int? Promotestatus { get; set; }

    public DateTime? Showlicensedate { get; set; }

    public int? Showlicensestatus { get; set; }
}
