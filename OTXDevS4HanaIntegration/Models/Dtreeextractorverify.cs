using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtreeextractorverify
{
    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public byte? New { get; set; }

    public byte? Correctionattempted { get; set; }

    public long? Retries { get; set; }

    public DateTime? Lastretry { get; set; }

    public long? Subtype { get; set; }

    public byte? Status { get; set; }

    public DateTime? Modifydate { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Partitionname { get; set; }

    public string? Partitionmode { get; set; }

    public long? Ownerid { get; set; }

    public string? Name { get; set; }

    public byte? Integrityerror { get; set; }

    public long? Contentstatus { get; set; }

    public long? Metadataerrors { get; set; }

    public string? Otobject { get; set; }
}
