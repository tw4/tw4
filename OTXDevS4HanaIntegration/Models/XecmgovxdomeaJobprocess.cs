using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovxdomeaJobprocess
{
    public long? Jobid { get; set; }

    public string Process { get; set; } = null!;

    public long? Logfiledataid { get; set; }

    public long? Zipfiledataid { get; set; }

    public long? Importfiledataid { get; set; }

    public string? Exportxmlpath { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public long? Coverletterdataid { get; set; }

    public byte? Confirmationrequired { get; set; }

    public byte? Feedbackrequired { get; set; }

    public long? Senderid { get; set; }

    public long? Recipientid { get; set; }

    public string? Hint { get; set; }
}
