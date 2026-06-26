using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapactSystem
{
    public string IdCfg { get; set; } = null!;

    public string Dest { get; set; } = null!;

    public string Client { get; set; } = null!;

    public string Sapsystemid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Ashost { get; set; }

    public string? Mshost { get; set; }

    public string? Groupname { get; set; }

    public string Sysnr { get; set; } = null!;

    public string? Baseurl { get; set; }

    public string? Username { get; set; }

    public byte? SncEnabled { get; set; }

    public string? SncPartnername { get; set; }

    public string? SncMyname { get; set; }

    public string? SncPse { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<OtsapactSystemsEnabled> OtsapactSystemsEnableds { get; set; } = new List<OtsapactSystemsEnabled>();
}
