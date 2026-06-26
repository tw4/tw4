using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Formdatum
{
    public long? Workid { get; set; }

    public long? Subworkid { get; set; }

    public long? Formid { get; set; }

    public long? Dataid { get; set; }

    public int? Lockflag { get; set; }
}
