using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapxecmRefLink
{
    public int? IdBoType { get; set; }

    public string IdBo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? Dataid { get; set; }

    public string? Comments { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Createdby { get; set; }

    public virtual OtsapBoTypesCore IdBoTypeNavigation { get; set; } = null!;
}
