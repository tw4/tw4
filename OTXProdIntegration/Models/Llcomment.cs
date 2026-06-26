using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llcomment
{
    public long? Commentsid { get; set; }

    public long? Nodeid { get; set; }

    public string Name { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Comments { get; set; }

    public long? Parentid { get; set; }

    public string Orderstring { get; set; } = null!;

    public long? Iconid { get; set; }
}
