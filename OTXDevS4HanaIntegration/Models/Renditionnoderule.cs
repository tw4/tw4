using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Renditionnoderule
{
    public long? Noderuleid { get; set; }

    public string Noderuletype { get; set; } = null!;

    public long? Dataid { get; set; }

    public long? Enabled { get; set; }

    public long? Includesubfolders { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Createdby { get; set; }
}
