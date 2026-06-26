using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmDocumentType
{
    public long? Ddataid { get; set; }

    public long? Cdataid { get; set; }

    public string Location { get; set; } = null!;

    public long? Valid { get; set; }

    public long? Rstype { get; set; }

    public long? Trequired { get; set; }
}
