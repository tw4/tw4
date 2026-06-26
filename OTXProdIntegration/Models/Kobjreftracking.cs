using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kobjreftracking
{
    public long? Rowseqnum { get; set; }

    public long? Eventdatenum { get; set; }

    public string? Profilekey { get; set; }

    public string? Instance { get; set; }

    public long? Threadindex { get; set; }

    public string? Eventclassname { get; set; }

    public string? Eventtag { get; set; }

    public string? Kosvaluename { get; set; }

    public string? Reftype { get; set; }

    public long? Maxval { get; set; }

    public long? Minval { get; set; }

    public long? Totalval { get; set; }

    public long? Totalcount { get; set; }
}
