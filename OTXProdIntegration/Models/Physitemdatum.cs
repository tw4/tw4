using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Physitemdatum
{
    public long? Nodeid { get; set; }

    public long? Mediatypeid { get; set; }

    public string Defaultlocation { get; set; } = null!;

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public int? Containernumber { get; set; }

    public string? Physitemkeywords { get; set; }

    public string? Locatortype { get; set; }

    public string? Area { get; set; }

    public string? Facility { get; set; }

    public string? Boxlocator { get; set; }

    public DateTime? Datesent { get; set; }

    public string? Refrate { get; set; }

    public string? Transferid { get; set; }

    public DateTime? Transreceived { get; set; }

    public string? Offsitestorid { get; set; }

    public long? Clientid { get; set; }

    public string? Client { get; set; }

    public string? Temporaryid { get; set; }
}
