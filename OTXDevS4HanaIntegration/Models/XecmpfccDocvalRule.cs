using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfccDocvalRule
{
    public long? Ruleid { get; set; }

    public long? Sdataid { get; set; }

    public long? Tdataid { get; set; }

    public long? Cdataid { get; set; }

    public string Location { get; set; } = null!;

    public long? Priority { get; set; }

    public byte? Required { get; set; }

    public string? Roles { get; set; }

    public long? Docgen { get; set; }

    public byte? ReviewRequired { get; set; }

    public byte? ValidityRequired { get; set; }

    public long? Validity { get; set; }

    public long? BasedOnCatId { get; set; }

    public long? BasedOnAttrId { get; set; }

    public long? Rstype { get; set; }

    public string Ruleexp { get; set; } = null!;

    public string Ruledata { get; set; } = null!;

    public string? Extendeddata { get; set; }

    public byte? Uploadreviewrequired { get; set; }

    public long? Uploadreviewwfmapid { get; set; }
}
