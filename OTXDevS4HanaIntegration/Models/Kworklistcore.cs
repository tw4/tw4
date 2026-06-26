using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kworklistcore
{
    public long? Rowidnum { get; set; }

    public long? Dataid { get; set; }

    public string? Data { get; set; }

    public short? Status { get; set; }

    public short? Type { get; set; }

    public DateTime? Lastupdate { get; set; }

    public short? Deleted { get; set; }
}
