using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class FileStatus
{
    public string FileStatus1 { get; set; } = null!;

    public string? FileStatusDescE { get; set; }

    public string? FileStatusDescF { get; set; }

    public string? Folderholdflag { get; set; }

    public byte? Dispositionflag { get; set; }

    public byte? Disabledflag { get; set; }
}
