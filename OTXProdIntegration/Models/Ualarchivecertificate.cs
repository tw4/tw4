using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Ualarchivecertificate
{
    public string Authcode { get; set; } = null!;

    public long? Archivedataid { get; set; }

    public short? Permissioncode { get; set; }

    public byte? Isenabled { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validtill { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public string? Serialcode { get; set; }

    public string? Fingerprintcode { get; set; }

    public string? Issuername { get; set; }

    public string? Certificatecontent { get; set; }
}
