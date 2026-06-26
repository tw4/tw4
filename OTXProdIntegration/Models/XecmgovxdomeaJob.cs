using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmgovxdomeaJob
{
    public long? Jobid { get; set; }

    public long? Originalcollectionid { get; set; }

    public string Xdomeaversion { get; set; } = null!;

    public string Currentprocess { get; set; } = null!;

    public byte? Currentstatus { get; set; }

    public long? Jobresultfolderid { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public string Jobguid { get; set; } = null!;

    public string? Errmsg { get; set; }

    public string? Feedbackarchiveid { get; set; }

    public string? Feedbackarchivelabel { get; set; }
}
