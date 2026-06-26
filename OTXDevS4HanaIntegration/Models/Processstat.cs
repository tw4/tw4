using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Processstat
{
    public long? Dataid { get; set; }

    public string? Processtype { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Data { get; set; }

    public long? Format { get; set; }
}
