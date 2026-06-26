using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Oldpassword
{
    public long? Userid { get; set; }

    public string Userpwd { get; set; } = null!;

    public DateTime? Datechanged { get; set; }

    public byte? Lastchanged { get; set; }
}
