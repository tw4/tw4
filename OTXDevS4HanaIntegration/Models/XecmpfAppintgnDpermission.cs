using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfAppintgnDpermission
{
    public string Permkey { get; set; } = null!;

    public long? Nodeid { get; set; }

    public long? Userid { get; set; }

    public long? Permsmask { get; set; }
}
