using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovOutboxevent
{
    public DateTime? Eventdate { get; set; }

    public long? Eventtype { get; set; }

    public long? Dataid { get; set; }

    public long? Performerid { get; set; }

    public long? Assignmentid { get; set; }

    public string? Fileddocname { get; set; }
}
