using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Physitemco
{
    public long? Nodeid { get; set; }

    public int? Copynumber { get; set; }

    public string? Location { get; set; }

    public string? Uniqueid { get; set; }

    public string? Chargedto { get; set; }

    public long? Userid { get; set; }

    public DateTime? Chargedate { get; set; }

    public DateTime? Returnby { get; set; }

    public int? Numreminders { get; set; }

    public long? Cparentid { get; set; }

    public string? Borrowcomment { get; set; }

    public long? Boxid { get; set; }

    public byte? Pickup { get; set; }

    public long? Obtainedbyid { get; set; }

    public string? Obtainedby { get; set; }

    public long? Borrowperformerid { get; set; }

    public DateTime? Actualborrowdate { get; set; }

    public byte? Securityoverride { get; set; }

    public byte? Acknowledge { get; set; }

    public long? Acknguid { get; set; }
}
