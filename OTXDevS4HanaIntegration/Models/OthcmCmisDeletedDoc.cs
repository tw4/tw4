using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OthcmCmisDeletedDoc
{
    public long? Dataid { get; set; }

    public string Name { get; set; } = null!;

    public long? SrcId { get; set; }

    public long? Ownerid { get; set; }

    public int? LinkTypeId { get; set; }

    public int? RetryCount { get; set; }

    public long? SfsfLinkDeleted { get; set; }
}
