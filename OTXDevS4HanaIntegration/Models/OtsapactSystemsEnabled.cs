using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapactSystemsEnabled
{
    public string Client { get; set; } = null!;

    public string Sapsystemid { get; set; } = null!;

    public string Dest { get; set; } = null!;

    public string IdCfg { get; set; } = null!;

    public virtual OtsapactSystem IdCfgNavigation { get; set; } = null!;
}
