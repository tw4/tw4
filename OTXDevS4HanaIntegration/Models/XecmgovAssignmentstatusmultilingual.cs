using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovAssignmentstatusmultilingual
{
    public string Languagecode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Display { get; set; }
}
