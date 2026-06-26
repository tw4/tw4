using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengsesynctrigger
{
    public long? Mappingid { get; set; }

    public byte? Triggertype { get; set; }

    public byte? Triggerevent { get; set; }

    public long? Triggerdataid { get; set; }
}
