using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Xengserecipientmap
{
    public long? Mappingid { get; set; }

    public byte? Recipienttype { get; set; }

    public long? Recipientid { get; set; }

    public byte? Permission { get; set; }
}
