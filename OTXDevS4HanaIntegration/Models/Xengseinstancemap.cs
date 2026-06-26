using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengseinstancemap
{
    public long? Workspaceid { get; set; }

    public long? Mappingid { get; set; }

    public long? Dataid { get; set; }

    public string Contractname { get; set; } = null!;
}
