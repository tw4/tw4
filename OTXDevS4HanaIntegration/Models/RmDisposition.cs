using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmDisposition
{
    public long? Dispnodeid { get; set; }

    public string? Retstage { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Rsi { get; set; }

    public long? Container { get; set; }

    public short? Objecttype { get; set; }

    public long? Recordcount { get; set; }

    public short? Runstatus { get; set; }

    public string? Action { get; set; }

    public string? Defaultactioninfo { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Accession { get; set; }

    public string? Objecttypes { get; set; }

    public byte? Enabled { get; set; }

    public string? Schedrecurtype { get; set; }

    public string? Schedtimeofday { get; set; }

    public string? Schedfloatdate { get; set; }

    public DateTime? Schednextrun { get; set; }

    public DateTime? Effectivedate { get; set; }

    public byte? Multisnapshots { get; set; }

    public byte? Autoprocess { get; set; }

    public byte? Excludecontainer { get; set; }

    public byte? Maximumretention { get; set; }

    public long? Savedqueryid { get; set; }

    public byte? Fromadvsearch { get; set; }

    public byte? Makerendition { get; set; }
}
