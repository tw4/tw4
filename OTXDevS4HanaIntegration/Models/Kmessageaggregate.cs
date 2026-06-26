using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Kmessageaggregate
{
    public long? Threadid { get; set; }

    public string Aggregatekey { get; set; } = null!;

    public long? Total { get; set; }
}
