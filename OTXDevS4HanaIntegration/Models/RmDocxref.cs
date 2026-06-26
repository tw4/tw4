using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDocxref
{
    public long? Dataid { get; set; }

    public string Docxreftyp { get; set; } = null!;

    public long? Xdataid { get; set; }

    public string? Docxrefcomment { get; set; }

    public long? Origid { get; set; }

    public long? Vernum { get; set; }
}
