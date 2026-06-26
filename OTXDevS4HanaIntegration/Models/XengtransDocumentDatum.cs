using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengtransDocumentDatum
{
    public long? Id { get; set; }

    public long? Dataid { get; set; }

    public long? SourceDataid { get; set; }

    public long? SourceVersion { get; set; }

    public string? SourceVertype { get; set; }

    public long? SourceParentid { get; set; }

    public string? Documentid { get; set; }

    public string? DocumentMetadata { get; set; }

    public byte? DocumentStatus { get; set; }

    public int? DocumentOrder { get; set; }
}
