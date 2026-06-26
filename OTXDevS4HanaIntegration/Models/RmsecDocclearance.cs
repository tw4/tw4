using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class RmsecDocclearance
{
    public long? Dataid { get; set; }

    public int? Initialsecurity { get; set; }

    public int? Currentsecurity { get; set; }

    public string? Reasonsfor { get; set; }

    public string? Classifiedby { get; set; }

    public string? Derivedfrom { get; set; }

    public byte? Declassifytype { get; set; }

    public DateTime? Declassifydate { get; set; }

    public string? Declassifyevent { get; set; }

    public string? Exemptioncats { get; set; }

    public string? Classifyingagency { get; set; }

    public byte? Downgradetype { get; set; }

    public DateTime? Downgradedate { get; set; }

    public string? Downgradeevent { get; set; }

    public string? Downgradeinst { get; set; }

    public DateTime? Reviewedon { get; set; }

    public string? Reviewedby { get; set; }

    public DateTime? Downgradedon { get; set; }

    public string? Downgradedby { get; set; }

    public DateTime? Declassifiedon { get; set; }

    public string? Declassifiedby { get; set; }

    public DateTime? Upgradedon { get; set; }

    public string? Upgradedby { get; set; }

    public string? Upgradereasons { get; set; }

    public byte? Datedirty { get; set; }
}
