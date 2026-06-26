using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dcatattr
{
    public string Catname { get; set; } = null!;

    public string Attrname { get; set; } = null!;

    public byte? Required { get; set; }
}
