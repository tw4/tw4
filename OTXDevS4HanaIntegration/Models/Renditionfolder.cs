using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Renditionfolder
{
    public long? Folderid { get; set; }

    public string Directory { get; set; } = null!;

    public string Mimetype { get; set; } = null!;

    public string Renditiontype { get; set; } = null!;
}
