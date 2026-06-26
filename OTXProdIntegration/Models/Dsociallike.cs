using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dsociallike
{
    public long? Userid { get; set; }

    public long? Itemid { get; set; }

    public DateTime? Createdate { get; set; }

    public byte? Ratingtype { get; set; }
}
