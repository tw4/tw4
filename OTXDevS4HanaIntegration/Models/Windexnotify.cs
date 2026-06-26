using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Windexnotify
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public int? Operation { get; set; }
}
