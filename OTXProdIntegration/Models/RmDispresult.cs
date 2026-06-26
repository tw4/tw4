using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class RmDispresult
{
    public long? Dispnodeid { get; set; }

    public long? Nodeid { get; set; }

    public string? Action { get; set; }

    public string? Defaultactioninfo { get; set; }

    public DateTime? Calculateddate { get; set; }

    public byte? Actionperformed { get; set; }

    public byte? Process { get; set; }

    public long? Classid { get; set; }

    public string? Rsi { get; set; }

    public DateTime? Qdate { get; set; }

    public string? Filenumber { get; set; }

    public short? Numverstokeep { get; set; }

    public byte? Purgesuperseded { get; set; }

    public byte? Purgemajors { get; set; }

    public byte? Advversioning { get; set; }

    public byte? Makerendition { get; set; }

    public long? Stagecount { get; set; }

    public long? Reviewerid { get; set; }

    public long? Reviewerid2 { get; set; }

    public short? Approvalstatus { get; set; }

    public long? Approverid { get; set; }

    public DateTime? Approveddate { get; set; }

    public long? Deletedchildkey { get; set; }
}
