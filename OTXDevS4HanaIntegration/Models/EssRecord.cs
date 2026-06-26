using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class EssRecord
{
    public string EssRecords { get; set; } = null!;

    public string? EssRecordsDescE { get; set; }

    public string? EssRecordsDescF { get; set; }

    public byte? Disabledflag { get; set; }
}
