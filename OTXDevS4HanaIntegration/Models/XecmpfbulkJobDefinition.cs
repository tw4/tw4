using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfbulkJobDefinition
{
    public long? Dataid { get; set; }

    public string JobType { get; set; } = null!;

    public string? ExtSysId { get; set; }

    public string? BusObjType { get; set; }

    public string? ConfigData { get; set; }

    public string? AgentId { get; set; }

    public string? JobStatus { get; set; }

    public long? Command { get; set; }

    public DateTime? ScheduleNextTime { get; set; }

    public string? ScheduleConfig { get; set; }
}
