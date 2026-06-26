using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XengtransSetting
{
    public long? Dataid { get; set; }

    public long? Coversheetid { get; set; }

    public byte? MakeRendition { get; set; }

    public string? RenditionType { get; set; }

    public byte? SendExistingRenditions { get; set; }

    public byte? SendNativeDocument { get; set; }

    public string? HeaderData { get; set; }

    public string? DocumentData { get; set; }

    public string? RecipientData { get; set; }

    public long? EmailConfigId { get; set; }

    public byte? EnableOutboundUpdates { get; set; }

    public long? TurnAroundDays { get; set; }

    public long? Ddmid { get; set; }
}
