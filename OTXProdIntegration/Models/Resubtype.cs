using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Resubtype
{
    public long? Rstype { get; set; }

    public string Typename { get; set; } = null!;

    public long? Rsactivation { get; set; }

    public int? Rsactivationunit { get; set; }

    public int? Deleted { get; set; }

    public long? Rsclient { get; set; }

    public int? Escalenabled { get; set; }

    public int? Escalation { get; set; }

    public int? Escalunit { get; set; }

    public int? Escalbday { get; set; }

    public int? Escalchange { get; set; }

    public long? Escalto { get; set; }

    public int? Rspriority { get; set; }
}
