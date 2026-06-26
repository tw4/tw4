using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class EcmlinkConfigAll
{
    public int? IdWkspType { get; set; }

    public string? WkspTypeName { get; set; }

    public int? WkspTypeDeleted { get; set; }

    public int? IndexingEnabled { get; set; }

    public int? WkspPolEnabled { get; set; }

    public string? WkspIcon { get; set; }

    public int? UseLocationManual { get; set; }

    public int? GenerateNameEarly { get; set; }

    public long? WkspTypeNodeId { get; set; }

    public int? IdBoType { get; set; }

    public string? BoTypeName { get; set; }

    public string? BusinessObjectType { get; set; }

    public long? BoTypeNodeId { get; set; }

    public int? BoTypeDeleted { get; set; }

    public string? AutoKeydef { get; set; }

    public int? BadiBeforeAdd { get; set; }

    public int? BadiBeforeDel { get; set; }

    public string? BusrefName { get; set; }

    public string? DisplayUrl { get; set; }

    public int? UseForBuswksp { get; set; }

    public int? IsDefaultDisplay { get; set; }

    public int? IsDefaultSearch { get; set; }

    public int? MetaDataMapping { get; set; }

    public int? TriggerAttr { get; set; }

    public long? TriggerCat { get; set; }

    public int? UseForBusref { get; set; }

    public int? EnableAutoAddBo { get; set; }

    public string? IdExtsystem { get; set; }

    public string? ConnType { get; set; }

    public int? ExtSystemEnabled { get; set; }
}
