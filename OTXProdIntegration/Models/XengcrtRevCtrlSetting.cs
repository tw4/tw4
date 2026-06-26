using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcrtRevCtrlSetting
{
    public long? RevisionCtrlNode { get; set; }

    public long? SigninRevSchemeId { get; set; }

    public long? OtherRevSchemeId { get; set; }

    public byte? AllowConcurrentRevision { get; set; }

    public byte? DisplayCustomColumns { get; set; }

    public byte? AllowActiveDocs { get; set; }
}
