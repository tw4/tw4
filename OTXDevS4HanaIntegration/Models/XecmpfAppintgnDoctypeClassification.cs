using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfAppintgnDoctypeClassification
{
    public long? Docclassid { get; set; }

    public long? Classficationid { get; set; }

    public string Doctypename { get; set; } = null!;

    public byte? Classificationtype { get; set; }

    public byte? Status { get; set; }

    public long? Version { get; set; }

    public string? Docclassuserdata { get; set; }
}
