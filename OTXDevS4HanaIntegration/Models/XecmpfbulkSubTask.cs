using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfbulkSubTask
{
    public long? SubtaskId { get; set; }

    public string? SubtaskData { get; set; }

    public long? JobDataid { get; set; }

    public string StatusCode { get; set; } = null!;

    public string? ErrMsg { get; set; }

    public long? Step { get; set; }

    public long? Extractors { get; set; }

    public long? Items { get; set; }

    public long? Run { get; set; }
}
