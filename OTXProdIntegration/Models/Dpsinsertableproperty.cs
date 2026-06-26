using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dpsinsertableproperty
{
    public long? Insertpropid { get; set; }

    public string Keyname { get; set; } = null!;

    public short? Enabled { get; set; }

    public short? Synchronized { get; set; }

    public string Displayname { get; set; } = null!;

    public string? Conversion { get; set; }

    public string? Fileproperty { get; set; }

    public short? Csattributetype { get; set; }
}
