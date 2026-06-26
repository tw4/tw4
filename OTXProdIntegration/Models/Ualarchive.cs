using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualarchive
{
    public long? Archivedataid { get; set; }

    public string Archivename { get; set; } = null!;

    public string Retentionmode { get; set; } = null!;

    public short? Protectionlevel { get; set; }

    public short? Archiveport { get; set; }

    public short? Archivesslport { get; set; }

    public long? Retentiondays { get; set; }

    public string? Archivetype { get; set; }

    public string? Sslmode { get; set; }
}
