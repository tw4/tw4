using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RecdOpiniontracking
{
    public long? Userid { get; set; }

    public long? Dataid { get; set; }

    public DateTime? Opiniondate { get; set; }

    public decimal? Rating { get; set; }

    public string? Usercomment { get; set; }

    public string? Userexplanation { get; set; }
}
