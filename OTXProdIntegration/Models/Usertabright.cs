using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Usertabright
{
    public string Tabname { get; set; } = null!;

    public long? Rightid { get; set; }

    public byte? Owneredit { get; set; }
}
