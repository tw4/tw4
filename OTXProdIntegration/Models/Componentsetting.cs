using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Componentsetting
{
    public string Id { get; set; } = null!;

    public string Componentname { get; set; } = null!;

    public string Settingname { get; set; } = null!;

    public string Setting { get; set; } = null!;
}
