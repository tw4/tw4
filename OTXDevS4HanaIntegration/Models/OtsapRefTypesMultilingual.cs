using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapRefTypesMultilingual
{
    public int? IdReferenceType { get; set; }

    public string LangCode { get; set; } = null!;

    public string PropType { get; set; } = null!;

    public string? PropValue { get; set; }
}
