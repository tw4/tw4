using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ddeleteditemsnode
{
    public long? Dataid { get; set; }

    public string Name { get; set; } = null!;

    public long? Deleteduser { get; set; }

    public DateTime? Deletedate { get; set; }

    public long? Parentid { get; set; }

    public DateTime? Purgedate { get; set; }

    public string? Deleteinfo { get; set; }

    public string? Context { get; set; }
}
