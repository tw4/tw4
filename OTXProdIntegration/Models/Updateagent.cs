using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Updateagent
{
    public string? AgentId { get; set; }

    public string? HostName { get; set; }

    public string? HostIp { get; set; }

    public string? HostPort { get; set; }

    public string? HostOs { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public DateTime? LastModifyDatetime { get; set; }

    public byte? Isactive { get; set; }

    public string? Metadata { get; set; }
}
