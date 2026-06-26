using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class InterviewGenerated
{
    public long? Docid { get; set; }

    public long? Parentid { get; set; }

    public string Name { get; set; } = null!;

    public string? Instanceid { get; set; }
}
