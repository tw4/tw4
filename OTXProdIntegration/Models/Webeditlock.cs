using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Webeditlock
{
    public long? Anchornid { get; set; }

    public long? Ownerid { get; set; }

    public DateTime? Expirydate { get; set; }

    public DateTime? Linkresdate { get; set; }
}
