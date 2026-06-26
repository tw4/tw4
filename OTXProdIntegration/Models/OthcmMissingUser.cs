using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmMissingUser
{
    public string SfGroupName { get; set; } = null!;

    public string SfUserId { get; set; } = null!;

    public string CsUserName { get; set; } = null!;
}
