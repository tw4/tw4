using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Justification
{
    public long? Justificationid { get; set; }

    public string? Jurisdcode { get; set; }

    public string? Citation { get; set; }

    public string? Legalref { get; set; }

    public string? Recaffected { get; set; }

    public string? Retcode { get; set; }

    public string? Retperiod { get; set; }

    public string? Disposition { get; set; }

    public string? Agency { get; set; }

    public string? JustifydescE { get; set; }
}
