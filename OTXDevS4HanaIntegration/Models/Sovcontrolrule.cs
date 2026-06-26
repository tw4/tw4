using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Sovcontrolrule
{
    public long? Dataid { get; set; }

    public int? Ruleid { get; set; }

    public int? Typeid { get; set; }

    public int? Orderid { get; set; }

    public string? Ruletype { get; set; }

    public int? Attr1type { get; set; }

    public int? Attr2type { get; set; }

    public string? Attr3type { get; set; }

    public string? Attr4type { get; set; }
}
