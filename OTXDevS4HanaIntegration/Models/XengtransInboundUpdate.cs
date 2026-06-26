using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengtransInboundUpdate
{
    public long? Id { get; set; }

    public long? Dataid { get; set; }

    public long? Documentid { get; set; }

    public byte? Status { get; set; }

    public string? DocumentMetadata { get; set; }

    public string? StatusMessage { get; set; }

    public byte? UpdatesReceived { get; set; }

    public long? MetadataExtractedVersion { get; set; }

    public long? SourceDataid { get; set; }

    public long? SeDeliverableId { get; set; }
}
