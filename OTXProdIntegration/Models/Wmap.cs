using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wmap
{
    public long? MapMapid { get; set; }

    public string MapStartlinks { get; set; } = null!;

    public string MapEndlinks { get; set; } = null!;

    public string? MapInitiatecb { get; set; }

    public string? MapCompletecb { get; set; }

    public string? MapDeletecb { get; set; }

    public string? MapPainter { get; set; }

    public int? MapFlags { get; set; }

    public string? MapTitle { get; set; }

    public string? MapDescription { get; set; }

    public string? MapInstructions { get; set; }

    public int? MapPriority { get; set; }

    public string? MapProject { get; set; }

    public long? MapOwnerid { get; set; }

    public string? MapUserdata { get; set; }

    public long? MapManagerid { get; set; }

    public int? MapDueduration { get; set; }

    public DateTime? MapDuedate { get; set; }

    public int? MapDuetime { get; set; }

    public DateTime? MapStartdate { get; set; }

    public string? MapStopcb { get; set; }

    public string? MapSuspendcb { get; set; }

    public string? MapResumecb { get; set; }

    public string? MapArchivecb { get; set; }

    public string? MapCustomdata { get; set; }

    public int? MapType { get; set; }

    public int? MapSubtype { get; set; }

    public long? MapMapobjid { get; set; }
}
