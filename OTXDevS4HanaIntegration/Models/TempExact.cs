using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class TempExact
{
    public long? Rid { get; set; }

    public long? Ownerid { get; set; }

    public long? Parentid { get; set; }

    public long? Dataid { get; set; }

    public long? Rightid { get; set; }

    public int? Permissions { get; set; }

    public byte? Acltype { get; set; }

    public byte? See { get; set; }
}
