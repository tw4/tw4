using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dispositionhold
{
    public long? Holdid { get; set; }

    public byte? Activehold { get; set; }

    public string? Object { get; set; }

    public string? Applypatron { get; set; }

    public DateTime? Dateapplied { get; set; }

    public string? Holdcomment { get; set; }

    public string? Holdtype { get; set; }

    public DateTime? Datetoremove { get; set; }

    public DateTime? Dateremoved { get; set; }

    public string? Removalpatron { get; set; }

    public string? Removalcomment { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Editpatron { get; set; }

    public string? Holdname { get; set; }

    public string? Alternateholdid { get; set; }

    public long? Parentid { get; set; }
}
