using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llproxy
{
    public long? Proxyid { get; set; }

    public short? Enabled { get; set; }

    public short? Port { get; set; }

    public string Hostname { get; set; } = null!;

    public string Displayname { get; set; } = null!;

    public string? Username { get; set; }
}
