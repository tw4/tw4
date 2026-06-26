using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class OtsapRefType
{
    public int? Deleted { get; set; }

    public int? IdReferenceType { get; set; }

    public int? WkspPolEnabled { get; set; }

    public string? WkspIcon { get; set; }

    public int? IndexingEnabled { get; set; }

    public int? UseLocationManual { get; set; }

    public int? GenerateNameEarly { get; set; }

    public long? ConfigNodeId { get; set; }

    public int? RmEnabled { get; set; }

    public int? UseBulkapi { get; set; }

    public int? CopyDisabled { get; set; }

    public long? WidgetImgDataid { get; set; }

    public int? AviatorEnabled { get; set; }

    public virtual ICollection<OtsapBoTypesCore> OtsapBoTypesCores { get; set; } = new List<OtsapBoTypesCore>();

    public virtual ICollection<OtsapxecmWkspNolink> OtsapxecmWkspNolinks { get; set; } = new List<OtsapxecmWkspNolink>();
}
