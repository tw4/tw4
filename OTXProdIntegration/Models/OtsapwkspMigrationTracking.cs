using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapwkspMigrationTracking
{
    public long? Id { get; set; }

    public long? Runid { get; set; }

    public long? Total { get; set; }

    public long? Inprogress { get; set; }

    public long? Completed { get; set; }

    public string? Errors { get; set; }

    public string? Objids { get; set; }

    public DateTime? Createdate { get; set; }

    public virtual OtsapwkspMigrationMapping IdNavigation { get; set; } = null!;
}
