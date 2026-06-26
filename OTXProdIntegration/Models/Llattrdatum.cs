using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Llattrdatum
{
    public long? Id { get; set; }

    public long? Vernum { get; set; }

    public long? Defid { get; set; }

    public long? Defvern { get; set; }

    public int? Attrid { get; set; }

    public int? Attrtype { get; set; }

    public int? Customid { get; set; }

    public int? Entrynum { get; set; }

    public long? Parentkeyid { get; set; }

    public long? Keyid { get; set; }

    public long? Valint { get; set; }

    public decimal? Valreal { get; set; }

    public DateTime? Valdate { get; set; }

    public string? Valstr { get; set; }

    public string? Vallong { get; set; }
}
