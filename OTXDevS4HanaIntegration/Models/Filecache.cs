using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Filecache
{
    public long? Seqnum { get; set; }

    public string? Uniqueid { get; set; }

    public string? Adminserver { get; set; }

    public DateTime? Lastaccessed { get; set; }
}
