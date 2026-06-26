using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Pwd
{
    public long? Id { get; set; }

    public string Pwd1 { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public int? Type { get; set; }
}
