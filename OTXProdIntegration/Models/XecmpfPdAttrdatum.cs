using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XecmpfPdAttrdatum
{
    public long? Dataid { get; set; }

    public long? Defid { get; set; }

    public long? Defvern { get; set; }

    public int? Setid { get; set; }

    public byte? Setrow { get; set; }

    public int? Attrid { get; set; }

    public byte? Attrrow { get; set; }

    public int? Attrtype { get; set; }

    public int? Status { get; set; }

    public string Defname { get; set; } = null!;

    public string Setname { get; set; } = null!;

    public string Attrname { get; set; } = null!;

    public string Boid { get; set; } = null!;

    public string Boname { get; set; } = null!;

    public string Propid { get; set; } = null!;

    public string Propname { get; set; } = null!;

    public string? Extendeddata { get; set; }
}
