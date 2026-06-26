using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmObjecthold
{
    public long? Holdid { get; set; }

    public long? Nodeid { get; set; }

    public byte? Activehold { get; set; }

    public string? Applycomments { get; set; }

    public long? Userid { get; set; }

    public string? Docxreftyp { get; set; }

    public long? Queryid { get; set; }

    public long? Uniquerunid { get; set; }
}
