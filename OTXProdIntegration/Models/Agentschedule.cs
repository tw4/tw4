using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Agentschedule
{
    public long? Schedid { get; set; }

    public long? Userid { get; set; }

    public int? Agentid { get; set; }

    public int? Enabled { get; set; }

    public int? Monthmask { get; set; }

    public int? Daymask { get; set; }

    public int? Hourmask { get; set; }

    public int? Minutemask { get; set; }

    public int? Timezoneoffset { get; set; }

    public DateTime? Lasttime { get; set; }

    public DateTime? Nexttime { get; set; }

    public int? Paramint1 { get; set; }

    public int? Paramint2 { get; set; }

    public string? Paramstr3 { get; set; }

    public string? Paramstr4 { get; set; }

    public long? Reportid { get; set; }

    public int? Reportoptions { get; set; }

    public long? Transportid { get; set; }

    public int? Msgtype { get; set; }

    public string? Msgaddress { get; set; }

    public string? Agentname { get; set; }
}
