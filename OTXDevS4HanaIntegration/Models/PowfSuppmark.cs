using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class PowfSuppmark
{
    public long? Id { get; set; }

    public short? Parpos { get; set; }

    public short? Pos { get; set; }

    public string Suppmark { get; set; } = null!;
}
