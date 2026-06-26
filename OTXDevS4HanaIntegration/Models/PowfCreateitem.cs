using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class PowfCreateitem
{
    public long? Id { get; set; }

    public long? Subtype { get; set; }

    public byte? Reltype { get; set; }

    public short? Parpos { get; set; }

    public short? Pos { get; set; }

    public string? Name { get; set; }

    public string? Dcomment { get; set; }

    public string? Location { get; set; }

    public string? Uniqueid { get; set; }

    public string? Keywords { get; set; }

    public short? Numberofcopies { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Locatortype { get; set; }

    public string? Refrate { get; set; }

    public string? Offsitestorid { get; set; }

    public string? ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? Temporaryid { get; set; }

    public byte? Generatelabel { get; set; }

    public string? Labeltype { get; set; }

    public short? Numberoflabels { get; set; }

    public short? Numberofitems { get; set; }

    public string? ClassId { get; set; }

    public string? ClassPath { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryPath { get; set; }

    public string? TargetElem { get; set; }

    public string? TargetId { get; set; }

    public string? TargetPath { get; set; }

    public string? TargetAttrselect { get; set; }

    public long? MapId { get; set; }

    public long? Taskid { get; set; }

    public string? Action { get; set; }
}
