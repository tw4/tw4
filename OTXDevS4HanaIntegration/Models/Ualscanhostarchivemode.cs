using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Ualscanhostarchivemode
{
    public long? Scanhostid { get; set; }

    public long? Archivemodeid { get; set; }

    public byte? Defaultflag { get; set; }

    public DateTime? Lasttouchdate { get; set; }
}
