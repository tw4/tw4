using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfbulkJobHistory
{
    public long? Dataid { get; set; }

    public long? Run { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishedDate { get; set; }

    public long? ProcessedItems { get; set; }

    public long? ErrorItems { get; set; }

    public long? ResultCode { get; set; }

    public string? ResultErrMsg { get; set; }

    public string? ResultErrItems { get; set; }

    public string? CustomColumnValues { get; set; }

    public long? DurationExtractors { get; set; }
}
