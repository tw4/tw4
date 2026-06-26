using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengseWorkspace
{
    public string SeProjectId { get; set; } = null!;

    public string SeProjectName { get; set; } = null!;

    public long? Workspaceid { get; set; }
}
