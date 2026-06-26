using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Thesterm
{
    public long? Termid { get; set; }

    public string? Term { get; set; }

    public int? Termtype { get; set; }

    public string? Language { get; set; }

    public string? Scopenote { get; set; }

    public string? Keyword { get; set; }

    public string? Termlevel { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Termcomments { get; set; }

    public string? Filenumber { get; set; }

    public string? Rsi { get; set; }

    public string? Termsource { get; set; }
}
