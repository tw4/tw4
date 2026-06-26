using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengtransInbUpdProcessing
{
    public long? Id { get; set; }

    public long? Dataid { get; set; }

    public long? Batchid { get; set; }

    public long? Loadsheetindex { get; set; }

    public string? DocumentData { get; set; }

    public byte? Status { get; set; }

    public string? StatusMessage { get; set; }
}
