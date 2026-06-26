using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapExtSystemsMultilingual
{
    public string IdExtsystem { get; set; } = null!;

    public string LangCode { get; set; } = null!;

    public string PropType { get; set; } = null!;

    public string? PropValue { get; set; }
}
