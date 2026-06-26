using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualarchivecomponent
{
    public long? Componentdataid { get; set; }

    public long? Archivedataid { get; set; }

    public string Documentcode { get; set; } = null!;

    public string Componentname { get; set; } = null!;

    public string Retentionmode { get; set; } = null!;

    public long? Versionnum { get; set; }

    public short? Protectionlevel { get; set; }

    public byte? Isaddon { get; set; }

    public DateTime? Retentiondate { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }
}
