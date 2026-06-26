using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CcmsendMailTable
{
    public int? Id { get; set; }

    public int? ProcessId { get; set; }

    public int? SubProcessId { get; set; }

    public string FromEmailAddress { get; set; } = null!;

    public string ToEmailAddress { get; set; } = null!;

    public string EmailSubject { get; set; } = null!;

    public string EmailBody { get; set; } = null!;

    public byte? IsHtml { get; set; }

    public byte? IsSent { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? SentDate { get; set; }

    public byte[]? Attachments { get; set; }
}
