using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class InterviewFetched
{
    public long? Locationid { get; set; }

    public string Instanceid { get; set; } = null!;

    public long? Docid { get; set; }
}
