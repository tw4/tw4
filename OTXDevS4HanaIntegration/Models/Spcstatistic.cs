using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Spcstatistic
{
    public long? Dataid { get; set; }

    public long? SpcStatRunstate { get; set; }

    public long? SpcStatTotalcount { get; set; }

    public string? SpcStatTotalbytes { get; set; }

    public long? SpcStatMovedcount { get; set; }

    public string? SpcStatMovedbytes { get; set; }

    public DateTime? SpcStatStartdate { get; set; }

    public DateTime? SpcStatEnddate { get; set; }

    public long? SpcStatEndstate { get; set; }

    public string? SpcStatErrormessage { get; set; }
}
