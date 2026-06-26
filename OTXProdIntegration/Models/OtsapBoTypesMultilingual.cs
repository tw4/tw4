using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapBoTypesMultilingual
{
    public int? IdBoType { get; set; }

    public string LangCode { get; set; } = null!;

    public string PropType { get; set; } = null!;

    public string? PropValue { get; set; }
}
