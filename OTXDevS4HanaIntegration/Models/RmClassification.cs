using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmClassification
{
    public long? Nodeid { get; set; }

    public string? Rsi { get; set; }

    public string? Filenumber { get; set; }

    public string? FileStatus { get; set; }

    public int? Createdate { get; set; }

    public int? FileStatusDate { get; set; }

    public string? Essential { get; set; }

    public string? Storage { get; set; }

    public string? Disposition { get; set; }

    public string? Keywords { get; set; }

    public string? Subject { get; set; }

    public string? Dispauthority { get; set; }

    public short? Cycleperiod { get; set; }

    public byte? Closedflag { get; set; }

    public int? Closeddate { get; set; }

    public int? Lastadditiondate { get; set; }

    public byte? Certmode { get; set; }

    public byte? Allowrmsubfiles { get; set; }

    public byte? Allowrmvolumes { get; set; }
}
