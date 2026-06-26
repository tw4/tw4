using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfeacActionAttrMap
{
    public long? CfgId { get; set; }

    public long? ActionAttrId { get; set; }

    public short? AamPosition { get; set; }

    public string MappingMethod { get; set; } = null!;

    public string MappingData { get; set; } = null!;

    public string MappingAttrName { get; set; } = null!;
}
