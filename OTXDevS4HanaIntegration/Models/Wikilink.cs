using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wikilink
{
    public long? Containerid { get; set; }

    public long? Sourceid { get; set; }

    public long? Targetid { get; set; }
}
