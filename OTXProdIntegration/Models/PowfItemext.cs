using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class PowfItemext
{
    public long? Id { get; set; }

    public short? Parpos { get; set; }

    public short? Pos { get; set; }

    public string Fieldname { get; set; } = null!;

    public string? Fieldvalue { get; set; }
}
