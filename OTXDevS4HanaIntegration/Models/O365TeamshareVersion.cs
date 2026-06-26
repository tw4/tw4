using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class O365TeamshareVersion
{
    public string Tenant { get; set; } = null!;

    public string Driveid { get; set; } = null!;

    public string Itemid { get; set; } = null!;

    public short? Versionid { get; set; }

    public string Versionlabel { get; set; } = null!;

    public string Hashcode { get; set; } = null!;
}
