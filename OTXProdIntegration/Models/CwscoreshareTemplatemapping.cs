using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class CwscoreshareTemplatemapping
{
    public long? Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long? Dataid { get; set; }

    public string Recipients { get; set; } = null!;

    public string Coordinators { get; set; } = null!;

    public byte? Coordinatortype { get; set; }

    public string Shareditems { get; set; } = null!;

    public long? Version { get; set; }

    public byte? InitTrigger { get; set; }

    public byte? TermTrigger { get; set; }

    public long? Status { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Modifieddate { get; set; }

    public long? Createdby { get; set; }

    public long? Modifiedby { get; set; }

    public string? Initiationattrexp { get; set; }

    public string? Initiationattrexpdata { get; set; }

    public string? Terminationattrexp { get; set; }

    public string? Terminationattrexpdata { get; set; }
}
