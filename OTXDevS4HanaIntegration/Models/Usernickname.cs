using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Usernickname
{
    public long? Userid { get; set; }

    public string Nickname { get; set; } = null!;

    public string? Domain { get; set; }

    public long? Pwpdataid { get; set; }

    public long? Xsl { get; set; }
}
