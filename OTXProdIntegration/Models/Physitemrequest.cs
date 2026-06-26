using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Physitemrequest
{
    public long? Requestid { get; set; }

    public long? Nodeid { get; set; }

    public long? Userid { get; set; }

    public DateTime? Dateofrequest { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Requestcomment { get; set; }

    public string? Requesttype { get; set; }

    public string? Contactperson { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }
}
