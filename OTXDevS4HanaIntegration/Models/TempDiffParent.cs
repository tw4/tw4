using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class TempDiffParent
{
    public long? Ownerid { get; set; }

    public long? Parentid { get; set; }

    public long? Dataid { get; set; }
}
