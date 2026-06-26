using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Otemailparticipant
{
    public long? Nodeid { get; set; }

    public string? Emailaddress { get; set; }

    public string? Fullname { get; set; }

    public long? Systemprovided { get; set; }

    public long? Participantrole { get; set; }

    public long? Participanttype { get; set; }
}
