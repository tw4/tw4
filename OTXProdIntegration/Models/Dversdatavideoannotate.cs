using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dversdatavideoannotate
{
    public long? Versionid { get; set; }

    public long? Commentid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Commentdate { get; set; }

    public string? Commentdesc { get; set; }

    public string? Annotation { get; set; }
}
