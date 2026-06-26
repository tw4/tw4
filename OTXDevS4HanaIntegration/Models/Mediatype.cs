using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Mediatype
{
    public long? Mediatypeid { get; set; }

    public int? Fieldnumber { get; set; }

    public string? Fieldname { get; set; }

    public string? Fielddisplay { get; set; }

    public short? Fieldtype { get; set; }

    public int? Fieldsize { get; set; }

    public int? Fieldorder { get; set; }

    public string? Popupvals { get; set; }

    public string? Defaultval { get; set; }

    public byte? Fieldrequired { get; set; }
}
