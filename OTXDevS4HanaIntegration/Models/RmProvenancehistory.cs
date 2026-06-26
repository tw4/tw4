using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmProvenancehistory
{
    public long? Nodeid { get; set; }

    public string? Provenancetype { get; set; }

    public string? Name { get; set; }

    public string? Provalternatename { get; set; }

    public string? Dcomment { get; set; }

    public string? Provalternatedesc { get; set; }

    public string? Provtext { get; set; }

    public DateTime? Provstartdate { get; set; }

    public DateTime? Provenddate { get; set; }

    public byte? Disableflag { get; set; }

    public DateTime? Editdate { get; set; }

    public string Editpatron { get; set; } = null!;
}
