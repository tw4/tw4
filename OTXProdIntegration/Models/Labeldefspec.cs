using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Labeldefspec
{
    public string Defspecs { get; set; } = null!;

    public string Labeldefname { get; set; } = null!;

    public string? Columnstoselect { get; set; }

    public string? Tablename { get; set; }
}
