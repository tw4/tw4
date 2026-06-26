using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapwkspMigrationMapping
{
    public long? Id { get; set; }

    public long? AreaDataid { get; set; }

    public long? PathDataid { get; set; }

    public int? Subtype { get; set; }

    public long? BwsTemplateid { get; set; }

    public int? Status { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Catid { get; set; }

    public string? Filterword { get; set; }

    public string? Filtercriteria { get; set; }

    public int? Recursive { get; set; }

    public long? Durationcatid { get; set; }

    public virtual ICollection<OtsapwkspMigrationTracking> OtsapwkspMigrationTrackings { get; set; } = new List<OtsapwkspMigrationTracking>();
}
