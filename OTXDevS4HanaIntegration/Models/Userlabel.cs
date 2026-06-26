using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Userlabel
{
    public long? Id { get; set; }

    public string Labeldefname { get; set; } = null!;

    public long? Userid { get; set; }

    public DateTime? Createdatetime { get; set; }

    public string? Labelcontent { get; set; }

    public byte? Printflag { get; set; }

    public short? Noofcopies { get; set; }
}
