using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Commcalendar
{
    public long? Id { get; set; }

    public long? Commid { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string Title { get; set; } = null!;

    public string? Details { get; set; }

    public string? Extendeddata { get; set; }
}
