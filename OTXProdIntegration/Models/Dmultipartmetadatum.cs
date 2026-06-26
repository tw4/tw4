using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dmultipartmetadatum
{
    public short? Status { get; set; }

    public long? Userid { get; set; }

    public long? Filesize { get; set; }

    public long? Numblocks { get; set; }

    public long? Maxcontentsize { get; set; }

    public DateTime? Firsttime { get; set; }

    public DateTime? Lasttime { get; set; }

    public string Uploadkey { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Tempdir { get; set; } = null!;

    public string Tempfile { get; set; } = null!;

    public string Mimetype { get; set; } = null!;
}
