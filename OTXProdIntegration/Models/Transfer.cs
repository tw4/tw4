using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Transfer
{
    public string Transferid { get; set; } = null!;

    public string? Transsortkey { get; set; }

    public long? Userid { get; set; }

    public DateTime? Trsfcreate { get; set; }

    public DateTime? Trsfsent { get; set; }

    public DateTime? Trsfrecd { get; set; }

    public string? Trsfcomment { get; set; }

    public decimal? Trsfestsize { get; set; }

    public DateTime? Trsfdatefrom { get; set; }

    public DateTime? Trsfdateto { get; set; }

    public string? Trsfcontent { get; set; }
}
