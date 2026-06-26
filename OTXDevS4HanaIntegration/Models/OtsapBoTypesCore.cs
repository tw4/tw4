using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class OtsapBoTypesCore
{
    public int? BoTypeDeleted { get; set; }

    public int? IdBoType { get; set; }

    public string BusinessObjectType { get; set; } = null!;

    public string IdExtsystem { get; set; } = null!;

    public int? IdReferenceType { get; set; }

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

    public virtual OtsapExtSystem IdExtsystemNavigation { get; set; } = null!;

    public virtual OtsapRefType? IdReferenceTypeNavigation { get; set; }

    public virtual ICollection<OtsapBoTypesPropgroup> OtsapBoTypesPropgroups { get; set; } = new List<OtsapBoTypesPropgroup>();

    public virtual ICollection<OtsapPolicy> OtsapPolicies { get; set; } = new List<OtsapPolicy>();

    public virtual ICollection<OtsapxecmRefLink> OtsapxecmRefLinks { get; set; } = new List<OtsapxecmRefLink>();

    public virtual ICollection<OtsapxecmWkspLink> OtsapxecmWkspLinks { get; set; } = new List<OtsapxecmWkspLink>();
}
