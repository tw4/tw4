using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovForwarddirectivesmultilingual
{
    public string Languagecode { get; set; } = null!;

    public string Directive { get; set; } = null!;

    public string? Display { get; set; }
}
