using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Docxreftyp
{
    public string Docxreftyp1 { get; set; } = null!;

    public string? DocxreftypDescE { get; set; }

    public string? DocxreftypDescF { get; set; }

    public string? Relatedcode { get; set; }

    public byte? Disabledflag { get; set; }

    public long? Holdid { get; set; }
}
