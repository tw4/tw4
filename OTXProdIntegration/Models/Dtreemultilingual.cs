using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dtreemultilingual
{
    public long? Dataid { get; set; }

    public string Languagecode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Dcomment { get; set; }
}
