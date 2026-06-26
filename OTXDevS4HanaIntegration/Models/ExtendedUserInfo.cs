using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class ExtendedUserInfo
{
    public string SfUserId { get; set; } = null!;

    public long? CsUserId { get; set; }

    public long? WsId { get; set; }
}
