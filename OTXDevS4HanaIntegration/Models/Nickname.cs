using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Nickname
{
    public long? Id { get; set; }

    public string Nickname1 { get; set; } = null!;

    public string Lowercasenickname { get; set; } = null!;

    public string? Domain { get; set; }
}
