using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class TestTable
{
    public long? Volumeid { get; set; }

    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public long? Seq { get; set; }

    public int? Rowseqnum { get; set; }

    public int? Iterationnum { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Alan1 { get; set; }

    public long? Alan2 { get; set; }

    public int? Aktif { get; set; }
}
