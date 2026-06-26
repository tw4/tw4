using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Dtreecoreexternaldatum
{
    public long? Dataid { get; set; }

    public long? Versionnum { get; set; }

    public DateTime? Externalcreatedate { get; set; }

    public DateTime? Externalmodifydate { get; set; }

    public long? Externalcreatorid { get; set; }

    public long? Externalsourceid { get; set; }

    public virtual Kuafidentity? Externalcreator { get; set; }

    public virtual Dtreecoreexternalsource? Externalsource { get; set; }
}
