using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OthcmUserManager
{
    public string SfUserId { get; set; } = null!;

    public string? SfUserName { get; set; }

    public string? SfUserStatus { get; set; }

    public string? SfPersonId { get; set; }

    public string? SfMgrUserId { get; set; }

    public long? SfPrimaryAccount { get; set; }
}
