using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualdocattribute
{
    public long? Archivedataid { get; set; }

    public string Documentcode { get; set; } = null!;

    public string Attributename { get; set; } = null!;

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public string? Attributevalue { get; set; }
}
