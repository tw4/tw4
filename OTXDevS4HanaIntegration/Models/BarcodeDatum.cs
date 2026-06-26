using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class BarcodeDatum
{
    public long? Barcodeid { get; set; }

    public DateTime? Barcodedate { get; set; }

    public string Docname { get; set; } = null!;

    public long? Creatorid { get; set; }

    public long? Dataid { get; set; }

    public int? Subtype { get; set; }

    public DateTime? Scandate { get; set; }
}
