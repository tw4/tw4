using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcrtRevisionScheme
{
    public long? RevSchemeId { get; set; }

    public byte? RevSchemeType { get; set; }

    public byte? MajorRevSchemeType { get; set; }

    public byte? MinorRevSchemeType { get; set; }

    public long? MajorInitialNumericRev { get; set; }

    public long? MinorInitialNumericRev { get; set; }

    public byte? ProjectRevSchemeType { get; set; }

    public string? Delimeter { get; set; }

    public string? MajorDisplayFormat { get; set; }

    public string? MinorDisplayFormat { get; set; }

    public string? MajorAlphaRevValues { get; set; }

    public string? MinorAlphaRevValues { get; set; }

    public string? ProjectAlphaRevValues { get; set; }

    public string? MajorRevisionLabel { get; set; }
}
