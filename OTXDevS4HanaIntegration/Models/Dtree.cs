using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Dtree
{
    public long? Ownerid { get; set; }

    public long? Parentid { get; set; }

    public long? Dataid { get; set; }

    public string Name { get; set; } = null!;

    public long? Originownerid { get; set; }

    public long? Origindataid { get; set; }

    public long? Userid { get; set; }

    public long? Groupid { get; set; }

    public int? Upermissions { get; set; }

    public int? Gpermissions { get; set; }

    public int? Wpermissions { get; set; }

    public int? Spermissions { get; set; }

    public int? Aclcount { get; set; }

    public long? Permid { get; set; }

    public long? Datatype { get; set; }

    public long? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Modifiedby { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Maxvers { get; set; }

    public byte? Reserved { get; set; }

    public long? Reservedby { get; set; }

    public DateTime? Reserveddate { get; set; }

    public long? Versionnum { get; set; }

    public string? Dcomment { get; set; }

    public string? Dcategory { get; set; }

    public int? Subtype { get; set; }

    public string? Exatt1 { get; set; }

    public string? Exatt2 { get; set; }

    public long? Ordering { get; set; }

    public long? Major { get; set; }

    public long? Minor { get; set; }

    public long? Releaseref { get; set; }

    public long? Childcount { get; set; }

    public long? Assignedto { get; set; }

    public DateTime? Dateassigned { get; set; }

    public DateTime? Dateeffective { get; set; }

    public DateTime? Dateexpiration { get; set; }

    public DateTime? Datedue { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Datecompleted { get; set; }

    public int? Status { get; set; }

    public int? Priority { get; set; }

    public string? Gif { get; set; }

    public string? Extendeddata { get; set; }

    public int? Catalog { get; set; }

    public int? Cacheexpiration { get; set; }

    public int? Deleted { get; set; }

    public byte[] Guid { get; set; } = null!;
}
