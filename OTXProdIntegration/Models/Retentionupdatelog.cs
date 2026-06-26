using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Retentionupdatelog
{
    public long? Nid { get; set; }

    public long? Nodeid { get; set; }

    public DateTime? Exectime { get; set; }

    public long? Versionno { get; set; }

    public string? Asarcid { get; set; }

    public string? Asdocid { get; set; }

    public string? Asretention { get; set; }

    public long? Errorid { get; set; }

    public string? Errormsg { get; set; }

    public long? Retrycount { get; set; }
}
