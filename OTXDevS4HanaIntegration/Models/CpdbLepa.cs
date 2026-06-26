using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class CpdbLepa
{
    public long? Cpid { get; set; }

    public int? Cptype { get; set; }

    public int? Deleted { get; set; }

    public string? Name { get; set; }

    public long? Cgid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public long? Spid { get; set; }

    public string? Zippostalcode { get; set; }

    public long? Coid { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public long? Logoid { get; set; }

    public string? Comments { get; set; }

    public DateTime? Creationdate { get; set; }

    public long? Creator { get; set; }

    public int? Version { get; set; }

    public long? Npfirm { get; set; }

    public int? Currentver { get; set; }

    public string? Cpextid { get; set; }

    public DateTime? Syncdate { get; set; }

    public int? Cpsection { get; set; }
}
