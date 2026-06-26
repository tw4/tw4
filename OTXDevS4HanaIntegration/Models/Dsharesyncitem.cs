using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsharesyncitem
{
    public long? Csitemid { get; set; }

    public short? Partialsyncstate { get; set; }

    public long? Csparentid { get; set; }

    public int? Cssubtype { get; set; }

    public long? Shareid { get; set; }

    public DateTime? Sharedon { get; set; }
}
