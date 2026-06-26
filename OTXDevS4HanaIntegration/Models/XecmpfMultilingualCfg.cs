using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfMultilingualCfg
{
    public string Id { get; set; } = null!;

    public string Namespace { get; set; } = null!;

    public string LangCode { get; set; } = null!;

    public string LangValue { get; set; } = null!;
}
