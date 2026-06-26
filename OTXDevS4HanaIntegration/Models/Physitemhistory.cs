using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Physitemhistory
{
    public long? Hid { get; set; }

    public long? Nodeid { get; set; }

    public DateTime? Chargedate { get; set; }

    public DateTime? Returnby { get; set; }

    public long? Userid { get; set; }

    public string? Chargedto { get; set; }

    public DateTime? Returndate { get; set; }

    public string? Borrowcomment { get; set; }

    public long? Obtainedbyid { get; set; }

    public string? Obtainedby { get; set; }

    public long? Borrowperformerid { get; set; }

    public DateTime? Actualborrowdate { get; set; }

    public long? Returnperformerid { get; set; }

    public DateTime? Actualreturndate { get; set; }

    public byte? Securityoverride { get; set; }

    public string? Returncomment { get; set; }

    public byte? Acknowledge { get; set; }
}
