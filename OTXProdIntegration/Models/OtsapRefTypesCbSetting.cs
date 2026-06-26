using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapRefTypesCbSetting
{
    public int? IdReferenceType { get; set; }

    public string CbUsage { get; set; } = null!;

    public string CbName { get; set; } = null!;

    public string CbParm { get; set; } = null!;

    public virtual OtsapRefType IdReferenceTypeNavigation { get; set; } = null!;
}
