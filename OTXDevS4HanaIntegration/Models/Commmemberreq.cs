using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Commmemberreq
{
    public long? Dataid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Roleid { get; set; }

    public string? Sponsor { get; set; }

    public string? Msg { get; set; }

    public long? Reqtype { get; set; }

    public string? Extendeddata { get; set; }
}
