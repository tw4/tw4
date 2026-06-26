using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Viewxpublication
{
    public long? Versionid { get; set; }

    public long? Viewxid { get; set; }

    public string? Xrefskey { get; set; }

    public string? Pubkey { get; set; }

    public short? Pollcount { get; set; }

    public short? Pollerrcount { get; set; }

    public byte? Iscomplete { get; set; }

    public long? Viewcount { get; set; }

    public byte? Keepcached { get; set; }

    public string Pubtype { get; set; } = null!;

    public short? Score { get; set; }

    public long? Totalsize { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Updatetime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Lastviewed { get; set; }

    public string? State { get; set; }

    public string? Statusmsg { get; set; }

    public string? Pubdata { get; set; }
}
