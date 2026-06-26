using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CcmsendMailAttachTable
{
    public int? Id { get; set; }

    public int? ProcessId { get; set; }

    public int? SubProcessId { get; set; }

    public byte? IsRead { get; set; }

    public string? DocumentIdArray { get; set; }
}
