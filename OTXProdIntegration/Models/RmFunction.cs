using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmFunction
{
    public short? Funcid { get; set; }

    public string Functionname { get; set; } = null!;

    public byte? Custmodule { get; set; }
}
