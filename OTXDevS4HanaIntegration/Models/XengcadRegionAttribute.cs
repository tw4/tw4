using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengcadRegionAttribute
{
    public long? Id { get; set; }

    public string? LayoutFilter { get; set; }

    public byte? Rtype { get; set; }

    public string? Rtypedef { get; set; }

    public string? TextFilter { get; set; }

    public byte? ResolutionType { get; set; }

    public string? ResolutionData { get; set; }
}
