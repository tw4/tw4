using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfxoVersion
{
    public long? Dataid { get; set; }

    public long? Versionid { get; set; }

    public string Externalid { get; set; } = null!;

    public long? Providerid { get; set; }
}
