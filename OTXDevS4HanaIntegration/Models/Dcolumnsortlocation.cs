using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dcolumnsortlocation
{
    public long? Dataid { get; set; }

    public long? Columnid { get; set; }

    public string Sortkey { get; set; } = null!;
}
