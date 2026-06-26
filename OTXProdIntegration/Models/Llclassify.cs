using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llclassify
{
    public long? Cid { get; set; }

    public long? Id { get; set; }

    public string? Status { get; set; }

    public string? Userclassified { get; set; }

    public string? Systemclassified { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Lastupdate { get; set; }

    public byte? Inheritflag { get; set; }
}
