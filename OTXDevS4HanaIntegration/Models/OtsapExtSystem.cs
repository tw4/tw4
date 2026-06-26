using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapExtSystem
{
    public string IdExtsystem { get; set; } = null!;

    public string Asurl { get; set; } = null!;

    public string ConnType { get; set; } = null!;

    public int? SchemaVersion { get; set; }

    public int? Enabled { get; set; }

    public string? Baseurl { get; set; }

    public string? Username { get; set; }

    public string? SystemComment { get; set; }

    public string? ClassName { get; set; }

    public long? CmisRootFolder { get; set; }

    public long? ExtsystemNodeId { get; set; }

    public string? AuthMethod { get; set; }

    public string? ClientId { get; set; }

    public string? TokenEndpoint { get; set; }

    public string? AsurlV4 { get; set; }

    public virtual ICollection<OtsapBoTypesCore> OtsapBoTypesCores { get; set; } = new List<OtsapBoTypesCore>();
}
