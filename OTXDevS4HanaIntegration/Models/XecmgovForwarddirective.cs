using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovForwarddirective
{
    public string Directive { get; set; } = null!;

    public long? Deletedby { get; set; }

    public DateTime? Deletedate { get; set; }

    public byte? Deleted { get; set; }
}
