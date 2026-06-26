using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Wmaptask
{
    public long? MaptaskMapid { get; set; }

    public int? MaptaskTaskid { get; set; }

    public int? MaptaskWaitcount { get; set; }

    public long? MaptaskSubmapid { get; set; }

    public long? MaptaskPerformerid { get; set; }

    public string? MaptaskInitiatecb { get; set; }

    public string? MaptaskCompletecb { get; set; }

    public string? MaptaskReadycb { get; set; }

    public string? MaptaskDonecb { get; set; }

    public string? MaptaskKillcb { get; set; }

    public string? MaptaskPerformercb { get; set; }

    public string? MaptaskSubmapidcb { get; set; }

    public string? MaptaskConditioncb { get; set; }

    public string? MaptaskCondition { get; set; }

    public string? MaptaskForm { get; set; }

    public string? MaptaskTruelinks { get; set; }

    public string? MaptaskFalselinks { get; set; }

    public string? MaptaskLooplinks { get; set; }

    public string? MaptaskPreviouslinks { get; set; }

    public string? MaptaskPainter { get; set; }

    public int? MaptaskDueduration { get; set; }

    public DateTime? MaptaskDuedate { get; set; }

    public int? MaptaskDuetime { get; set; }

    public int? MaptaskFlags { get; set; }

    public string? MaptaskTitle { get; set; }

    public string? MaptaskDescription { get; set; }

    public string? MaptaskInstructions { get; set; }

    public int? MaptaskPriority { get; set; }

    public string? MaptaskUserdata { get; set; }

    public DateTime? MaptaskStartdate { get; set; }

    public string? MaptaskResurrectcb { get; set; }

    public string? MaptaskCustomdata { get; set; }

    public int? MaptaskType { get; set; }

    public int? MaptaskSubtype { get; set; }

    public string? MaptaskBeforesendcb { get; set; }
}
