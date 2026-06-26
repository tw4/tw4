using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Todobase
{
    public long? WorkWorkid { get; set; }

    public long? WorkOwnerid { get; set; }

    public long? WorkManagerid { get; set; }

    public short? WorkStatus { get; set; }

    public int? WorkOwnerperms { get; set; }

    public long? SubworkSubworkid { get; set; }

    public string? SubworkTitle { get; set; }

    public short? SubworkStatus { get; set; }

    public int? SubworktaskTaskid { get; set; }

    public long? SubworktaskPerformerid { get; set; }

    public string? SubworktaskTitle { get; set; }

    public DateTime? SubworktaskDatemilestone { get; set; }

    public DateTime? SubworktaskDatedueMax { get; set; }

    public DateTime? SubworktaskDateready { get; set; }

    public string? SubworktaskUserdata { get; set; }

    public DateTime? MaptaskStartdate { get; set; }

    public int? MaptaskType { get; set; }

    public int? MaptaskSubtype { get; set; }

    public int? MaptaskPriority { get; set; }
}
