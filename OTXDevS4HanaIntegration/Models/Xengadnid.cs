using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xengadnid
{
    public long? Adnid { get; set; }

    public long? Adntype { get; set; }

    public string? Seqid { get; set; }

    public string Wholeid { get; set; } = null!;

    public byte? Status { get; set; }

    public long? Requestedby { get; set; }

    public long? Assignedby { get; set; }

    public string Adnidpattern { get; set; } = null!;
}
