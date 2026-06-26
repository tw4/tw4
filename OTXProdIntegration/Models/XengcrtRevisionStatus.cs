using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class XengcrtRevisionStatus
{
    public long? RevStatusId { get; set; }

    public long? RevisionCtrlNode { get; set; }

    public long? RevStatusOrder { get; set; }

    public byte? IsDisabled { get; set; }

    public string RevStatusName { get; set; } = null!;

    public byte? CanSignIn { get; set; }

    public byte? CanSignOut { get; set; }

    public string? Description { get; set; }

    public string? SuccessorRevStatus { get; set; }
}
