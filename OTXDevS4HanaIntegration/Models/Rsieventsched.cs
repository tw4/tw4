using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Rsieventsched
{
    public string Rsi { get; set; } = null!;

    public string Object { get; set; } = null!;

    public string Retstage { get; set; } = null!;

    public long? Rsischeduleid { get; set; }

    public short? Recordtype { get; set; }

    public byte? Eventtype { get; set; }

    public string? Rsirulecode { get; set; }

    public string? Datetouse { get; set; }

    public byte? Yearendmonth { get; set; }

    public byte? Yearendday { get; set; }

    public int? Retyears { get; set; }

    public int? Retmonths { get; set; }

    public int? Retdays { get; set; }

    public DateTime? Eventruledate { get; set; }

    public string? Eventrule { get; set; }

    public string? Eventcomment { get; set; }

    public string? Stageaction { get; set; }

    public string? Disposition { get; set; }

    public string? ActiondescE { get; set; }

    public string? ActiondescF { get; set; }

    public string? Recmdoffice { get; set; }

    public string? Recmdpatron { get; set; }

    public DateTime? Recmddate { get; set; }

    public string? Recmdcomment { get; set; }

    public byte? Approvalflag { get; set; }

    public byte? Retintervals { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Editpatron { get; set; }

    public string? Actioncode { get; set; }

    public string? RmRrCode { get; set; }

    public int? Maximumperiod { get; set; }

    public string? Eventrulecomment { get; set; }

    public byte? Fixedret { get; set; }

    public string? Catidattrid { get; set; }

    public int? Numverstokeep { get; set; }

    public byte? Purgesuperseded { get; set; }

    public byte? Purgemajors { get; set; }

    public byte? Makerendition { get; set; }
}
