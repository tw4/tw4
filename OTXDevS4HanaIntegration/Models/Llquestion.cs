using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llquestion
{
    public long? Questionid { get; set; }

    public short? Urgency { get; set; }

    public DateTime? Expirationdate { get; set; }

    public short? Closed { get; set; }

    public DateTime? Closeddate { get; set; }

    public short? Commentsnum { get; set; }

    public short? Suggestednum { get; set; }

    public short? Rejectednum { get; set; }

    public short? Acceptednum { get; set; }
}
