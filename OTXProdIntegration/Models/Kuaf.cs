using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Kuaf
{
    public long? Id { get; set; }

    public long? Ownerid { get; set; }

    public long? Type { get; set; }

    public long? Spaceid { get; set; }

    public string Name { get; set; } = null!;

    public string? Userdata { get; set; }

    public long? Leaderid { get; set; }

    public byte? Deleted { get; set; }

    public string? Userpwd { get; set; }

    public long? Groupid { get; set; }

    public int? Userprivileges { get; set; }

    public string? Lastname { get; set; }

    public string? Middlename { get; set; }

    public string? Firstname { get; set; }

    public string? Mailaddress { get; set; }

    public string? Contact { get; set; }

    public string? Title { get; set; }

    public DateTime? Pwdexpiredate { get; set; }

    public int? Pwdexpiremode { get; set; }

    public short? Settingsnum { get; set; }

    public string? Fax { get; set; }

    public string? Officelocation { get; set; }

    public short? Timezone { get; set; }

    public long? Photoid { get; set; }

    public byte? Gender { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Personalemail { get; set; }

    public string? Homeaddress1 { get; set; }

    public string? Homeaddress2 { get; set; }

    public string? Homephone { get; set; }

    public string? Homefax { get; set; }

    public string? Cellularphone { get; set; }

    public string? Pager { get; set; }

    public string? Homepage { get; set; }

    public string? Favorites1 { get; set; }

    public string? Favorites2 { get; set; }

    public string? Favorites3 { get; set; }

    public string? Interests { get; set; }
}
