using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dsignaturerequest
{
    public long? Requestid { get; set; }

    public long? Userid { get; set; }

    public short? Status { get; set; }

    public string Providerrequestkey { get; set; } = null!;

    public string Providername { get; set; } = null!;

    public string? Providerusername { get; set; }

    public DateTime? Lastupdate { get; set; }

    public DateTime? Created { get; set; }

    public string? Datastring { get; set; }
}
