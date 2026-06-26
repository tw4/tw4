using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class XecmgovAssignment
{
    public long? Dataid { get; set; }

    public long? Assignmentid { get; set; }

    public string Assignmentname { get; set; } = null!;

    public string? Instruction { get; set; }

    public int? Creatorpermissions { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public byte? Completed { get; set; }
}
