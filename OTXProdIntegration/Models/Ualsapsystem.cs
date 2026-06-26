using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualsapsystem
{
    public long? Sapsystemid { get; set; }

    public string Clientcode { get; set; } = null!;

    public string Instancecode { get; set; } = null!;

    public string Pagecode { get; set; } = null!;

    public string Connectionname { get; set; } = null!;

    public string Saphostname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Languagecode { get; set; } = null!;

    public DateTime? Lasttouchdate { get; set; }

    public string? Sapcomment { get; set; }
}
