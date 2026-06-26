using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Locatorlabel
{
    public string Facility { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Boxlocator { get; set; } = null!;

    public string Labeldefname { get; set; } = null!;

    public long? Userid { get; set; }

    public DateTime? Createdatetime { get; set; }

    public string? Labelcontent { get; set; }

    public byte? Printflag { get; set; }

    public int? Noofcopies { get; set; }
}
