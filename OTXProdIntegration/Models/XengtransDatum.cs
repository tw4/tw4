using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengtransDatum
{
    public long? Dataid { get; set; }

    public byte? Status { get; set; }

    public long? Coversheetid { get; set; }

    public long? DocumentFolderid { get; set; }

    public long? AdditionalDocFolderid { get; set; }

    public string? StatusMessage { get; set; }

    public long? Loadsheetid { get; set; }

    public long? LoadsheetVersion { get; set; }

    public DateTime? SentDate { get; set; }

    public DateTime? ForecastDate { get; set; }

    public DateTime? ActualDate { get; set; }
}
