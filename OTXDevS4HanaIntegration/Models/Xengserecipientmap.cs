using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengserecipientmap
{
    public long? Mappingid { get; set; }

    public byte? Recipienttype { get; set; }

    public long? Recipientid { get; set; }

    public byte? Permission { get; set; }
}
