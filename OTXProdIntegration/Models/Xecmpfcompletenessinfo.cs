using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Xecmpfcompletenessinfo
{
    public long? Workspaceid { get; set; }

    public long? Templateid { get; set; }

    public long? Documenttypeid { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Expiredate { get; set; }

    public long? Docid { get; set; }

    public long? Catid { get; set; }

    public long? Attrid { get; set; }

    public long? Validity { get; set; }

    public byte? Required { get; set; }

    public string? Role { get; set; }

    public string Doclocationws { get; set; } = null!;

    public string Doclocation { get; set; } = null!;
}
