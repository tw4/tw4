using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Otemailproperty
{
    public long? Nodeid { get; set; }

    public string? Otemailsubject { get; set; }

    public string? Otemailto { get; set; }

    public string? Otemailcc { get; set; }

    public string? Otemailfrom { get; set; }

    public DateTime? Otemailsentdate { get; set; }

    public DateTime? Otemailreceiveddate { get; set; }

    public long? Bodyformat { get; set; }

    public long? Hasattachments { get; set; }

    public long? Inserttype { get; set; }

    public long? Version { get; set; }

    public long? Messagetype { get; set; }

    public string? Messageid { get; set; }

    public long? Signedencrypted { get; set; }

    public string? Otemailbcc { get; set; }

    public string? Otemailonbehalfof { get; set; }
}
