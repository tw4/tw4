using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dversdatavideotranscode
{
    public long? Versionid { get; set; }

    public string Transcodekey { get; set; } = null!;

    public DateTime? Transcodedate { get; set; }

    public long? Retrynum { get; set; }

    public long? Userid { get; set; }

    public string Filename { get; set; } = null!;
}
