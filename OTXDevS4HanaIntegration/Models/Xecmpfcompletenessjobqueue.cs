using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Xecmpfcompletenessjobqueue
{
    public long? Workspaceid { get; set; }

    public byte? Cat1change { get; set; }

    public byte? Cat2change { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Lastprocessedtime { get; set; }

    public DateTime? Debouncetime { get; set; }

    public string? Cat1metadata { get; set; }

    public string? Cat2metadata { get; set; }
}
