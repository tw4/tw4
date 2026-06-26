using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dversdatum
{
    public long? Versionid { get; set; }

    public long? Docid { get; set; }

    public long? Version { get; set; }

    public string Versionname { get; set; } = null!;

    public long? Owner { get; set; }

    public DateTime? Vercdate { get; set; }

    public DateTime? Vermdate { get; set; }

    public byte? Platform { get; set; }

    public string? Filename { get; set; }

    public long? Datasize { get; set; }

    public long? Ressize { get; set; }

    public string? Filetype { get; set; }

    public string? Filecreator { get; set; }

    public DateTime? Filecdate { get; set; }

    public DateTime? Filemdate { get; set; }

    public string? Icon { get; set; }

    public long? Providerid { get; set; }

    public string? Vercomment { get; set; }

    public byte? Locked { get; set; }

    public long? Lockedby { get; set; }

    public DateTime? Lockeddate { get; set; }

    public byte? Indexed { get; set; }

    public int? Finderflags { get; set; }

    public string? Mimetype { get; set; }

    public string? Vertype { get; set; }

    public long? Vermajor { get; set; }

    public long? Verminor { get; set; }

    public byte[] Guid { get; set; } = null!;

    public int? Pagenum { get; set; }

    public long? Transient { get; set; }

    public virtual Providerdatum Provider { get; set; } = null!;
}
