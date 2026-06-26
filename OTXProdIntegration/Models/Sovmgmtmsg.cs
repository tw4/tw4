using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Sovmgmtmsg
{
    public string? Name { get; set; }

    public string? Sigid { get; set; }

    public string? Objtype { get; set; }

    public string? Msg { get; set; }

    public DateTime? Msgdate { get; set; }

    public string? Cmpmsg { get; set; }

    public string? Type { get; set; }

    public string? Bseen { get; set; }

    public string? Recipient { get; set; }
}
