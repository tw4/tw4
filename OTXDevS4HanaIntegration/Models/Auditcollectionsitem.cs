using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Auditcollectionsitem
{
    public long? Sequencenumber { get; set; }

    public long? Nodeid { get; set; }

    public string? Operation { get; set; }

    public string Status { get; set; } = null!;

    public long? Fromlocationid { get; set; }

    public long? Tolocationid { get; set; }

    public string? Userlogin { get; set; }

    public long? Userid { get; set; }

    public string? Userlocation { get; set; }

    public DateTime? Modifydate { get; set; }

    public long? Version { get; set; }

    public byte? Discoveryperm { get; set; }
}
