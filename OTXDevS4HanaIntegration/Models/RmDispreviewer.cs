using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDispreviewer
{
    public long? Dispnodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public long? Reviewerid { get; set; }

    public short? Reviewerstep { get; set; }

    public long? Recordcount { get; set; }

    public short? Reviewstatus { get; set; }

    public DateTime? Notificationdate { get; set; }

    public short? Overduecount { get; set; }

    public DateTime? Overdueemaildate { get; set; }
}
