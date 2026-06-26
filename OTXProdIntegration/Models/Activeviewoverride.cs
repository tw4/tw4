using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Activeviewoverride
{
    public long? Id { get; set; }

    public string Activeviewtype { get; set; } = null!;

    public long? Nodeid { get; set; }

    public long? Seq { get; set; }

    public long? Avid { get; set; }

    public string? Expression { get; set; }

    public long? Priority { get; set; }

    public long? Cascadevalue { get; set; }

    public string? Overrideinfo { get; set; }

    public byte? Overrideclass { get; set; }

    public byte? Pmancompatible { get; set; }

    public string? Ruledata { get; set; }
}
