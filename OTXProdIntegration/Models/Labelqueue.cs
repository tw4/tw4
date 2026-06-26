using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Labelqueue
{
    public long? Nodeid { get; set; }

    public string Labeldefname { get; set; } = null!;

    public string? Uniqueid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Createdatetime { get; set; }

    public string? Labelcontent { get; set; }

    public byte? Printflag { get; set; }

    public int? Noofcopies { get; set; }
}
