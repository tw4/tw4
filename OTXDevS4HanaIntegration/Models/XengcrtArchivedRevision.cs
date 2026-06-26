using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengcrtArchivedRevision
{
    public long? RevisionId { get; set; }

    public long? DrawingId { get; set; }

    public long? NodeId { get; set; }

    public long? RevStatusId { get; set; }

    public byte? RevIndicator { get; set; }

    public long? RevisionNumber { get; set; }

    public long? Version { get; set; }

    public long? ProjectWkspId { get; set; }

    public int? ProcessType { get; set; }

    public byte? IsParticipant { get; set; }

    public string MajorRevision { get; set; } = null!;

    public long? SourceRevisionId { get; set; }

    public long? RevSchemeId { get; set; }

    public long? RequestedUser { get; set; }

    public DateTime? RequestedDate { get; set; }

    public long? ApprovedUser { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? MinorRevision { get; set; }

    public string? ProjectRevision { get; set; }

    public string? Delimeter { get; set; }

    public string? RevsionNotes { get; set; }
}
