using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreemultilingual
{
    public long? Dataid { get; set; }

    public string Languagecode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Dcomment { get; set; }
}
