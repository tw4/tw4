using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapBoTypesCbSetting
{
    public int? IdBoType { get; set; }

    public string CbUsage { get; set; } = null!;

    public string CbName { get; set; } = null!;

    public string CbParm { get; set; } = null!;

    public long? CbMultival { get; set; }

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
