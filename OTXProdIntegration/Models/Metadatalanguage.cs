using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Metadatalanguage
{
    public string Languagecode { get; set; } = null!;

    public byte? Enabled { get; set; }
}
