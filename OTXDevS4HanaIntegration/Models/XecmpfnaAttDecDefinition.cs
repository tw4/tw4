using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmpfnaAttDecDefinition
{
    public long? IdDeclarationType { get; set; }

    public string Name { get; set; } = null!;

    public long? DeclarationNodeId { get; set; }

    public string? Description { get; set; }

    public string? ExternalSystem { get; set; }

    public string? DocPropertyProvider { get; set; }

    public string? BusinessProperties { get; set; }

    public string? BusinessPropertyGrps { get; set; }

    public string? RootFolder { get; set; }

    public string? SubFolder { get; set; }

    public string? Classification { get; set; }

    public string? DocNames { get; set; }

    public string? RmClassification { get; set; }

    public string? RecordDate { get; set; }

    public string? Status { get; set; }

    public string? StatusDate { get; set; }

    public string? MarkOfficial { get; set; }

    public string? AttributeList { get; set; }

    public int? Deleted { get; set; }
}
