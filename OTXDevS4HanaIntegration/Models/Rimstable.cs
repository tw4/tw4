using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Rimstable
{
    public string Tablename { get; set; } = null!;

    public string Columnname { get; set; } = null!;

    public string? TabledescE { get; set; }

    public string? TabledescF { get; set; }

    public string? ColdescE { get; set; }

    public string? ColdescF { get; set; }

    public string? Coltype { get; set; }

    public long? Attribute { get; set; }

    public string? Bitmap { get; set; }

    public long? Colposition { get; set; }

    public string? FieldDescE { get; set; }

    public string? FieldDescF { get; set; }

    public string? Objectfield { get; set; }

    public string? Object { get; set; }

    public long? Rimsconfigfilter { get; set; }

    public long? Advsrchflag { get; set; }

    public long? Coldatalength { get; set; }

    public string? Lookupinfo { get; set; }

    public long? Quickfindflag { get; set; }

    public long? Additionalsrchflag { get; set; }
}
