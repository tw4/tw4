using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wsubworktask
{
    public long? SubworktaskWorkid { get; set; }

    public long? SubworktaskSubworkid { get; set; }

    public int? SubworktaskTaskid { get; set; }

    public int? SubworktaskWaitcount { get; set; }

    public long? SubworktaskPerformerid { get; set; }

    public DateTime? SubworktaskDatedueMin { get; set; }

    public DateTime? SubworktaskDatedueMax { get; set; }

    public DateTime? SubworktaskDatemilestone { get; set; }

    public DateTime? SubworktaskDateready { get; set; }

    public DateTime? SubworktaskDatedone { get; set; }

    public short? SubworktaskStatus { get; set; }

    public int? SubworktaskFlags { get; set; }

    public int? SubworktaskType { get; set; }

    public string? SubworktaskTitle { get; set; }

    public string? SubworktaskUserdata { get; set; }

    public string? SubworktaskCustomdata { get; set; }

    public int? SubworktaskIternum { get; set; }
}
