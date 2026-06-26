using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapBoType
{
    public int? BoTypeDeleted { get; set; }

    public int? IdBoType { get; set; }

    public string BusinessObjectType { get; set; } = null!;

    public string IdExtsystem { get; set; } = null!;

    public int? IdReferenceType { get; set; }

    public string BoTypeName { get; set; } = null!;

    public string? DisplayUrl { get; set; }

    public int? UseForBusref { get; set; }

    public int? BadiBeforeAdd { get; set; }

    public int? BadiBeforeDel { get; set; }

    public string? BusrefName { get; set; }

    public int? MetaDataMapping { get; set; }

    public long? TriggerCat { get; set; }

    public int? TriggerAttr { get; set; }

    public string? AutoKeydef { get; set; }

    public int? IsDefaultSearch { get; set; }

    public int? IsDefaultDisplay { get; set; }

    public long? BoTypeNodeId { get; set; }

    public int? UseForBuswksp { get; set; }

    public int? EnableAutoAddBo { get; set; }
}
