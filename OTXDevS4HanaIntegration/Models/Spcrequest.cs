using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Spcrequest
{
    public long? SpcRequesttype { get; set; }

    public long? SpcRequeststate { get; set; }

    public long? Dataid { get; set; }

    public string SpcOriginatortype { get; set; } = null!;
}
