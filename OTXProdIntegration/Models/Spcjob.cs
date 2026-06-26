using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Spcjob
{
    public long? Dataid { get; set; }

    public string SpcConditiontype { get; set; } = null!;

    public string? SpcConditionvalue { get; set; }

    public long? SpcRunstate { get; set; }

    public long? SpcActivity { get; set; }

    public string? SpcResumeinfo { get; set; }

    public string? SpcErrormessage { get; set; }

    public DateTime? SpcLaststartedat { get; set; }

    public DateTime? SpcLastendedat { get; set; }

    public long? SpcRecurrence { get; set; }

    public DateTime? SpcStartdate { get; set; }

    public DateTime? SpcEnddate { get; set; }
}
