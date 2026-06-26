using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDispreviewcomment
{
    public long? Dispnodeid { get; set; }

    public DateTime? Qdate { get; set; }

    public long? Nodeid { get; set; }

    public long? Stagecount { get; set; }

    public long? Userid { get; set; }

    public DateTime? Commentdate { get; set; }

    public string? Reviewcomment { get; set; }
}
