using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Wsubworktaskdatesummary
{
    public long? SubworktasksummaryWorkid { get; set; }

    public long? SubworktasksummarySubworkid { get; set; }

    public DateTime? SubworktaskCalcdatemilestone { get; set; }

    public DateTime? SubworktaskCalcdatedue { get; set; }

    public short? SubtaskscaldatesFlags { get; set; }
}
